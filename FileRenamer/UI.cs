using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Microsoft.WindowsAPICodePack.Dialogs;

namespace FileRenamer
{
    public partial class UI : Form
    {
        public UI()
        {
            InitializeComponent();
        }

        private const string colRename = "Rename?";
        private const string colFileName = "File Name";
        private const string colNewName = "New Name";


        private DirectoryInfo selectedDirectory;
        private DataTable dt;

        private void btnSelPath_Click(object sender, EventArgs e)
        {
            using (var cfDialog = new CommonOpenFileDialog())
            {
                cfDialog.IsFolderPicker = true;

                DialogResult dr = (DialogResult)cfDialog.ShowDialog();

                if (dr == DialogResult.OK)
                {
                    selectedDirectory = new DirectoryInfo(cfDialog.FileName);
                    lblPath.Text = $"Path: {cfDialog.FileName}\\";
                }
            }

            if (selectedDirectory != null)
            {
                FilesGridView.DataSource = filesTable(selectedDirectory.GetFiles());
                dgvSetup();
            }

        }

        private void btnCommitRename_Click(object sender, EventArgs e)
        {
            foreach (DataRow row in dt.Rows)
            {
                if((bool)row[colRename])
                {
                    File.Move($"{selectedDirectory}\\{row[colFileName]}", $"{selectedDirectory}\\{row[colNewName]}");
                }
            }
            FilesGridView.DataSource = filesTable(selectedDirectory.GetFiles());
            dgvSetup();
        }

        private void UI_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private DataTable filesTable(FileInfo[] files)
        {
            dt = new DataTable();
            dt.Columns.Add(colRename, typeof(bool));
            dt.Columns.Add(colFileName);
            dt.Columns.Add(colNewName);

            foreach (FileInfo file in files)
            {
                dt.Rows.Add(new object[] { false, file.Name, file.Name });
            }

            return dt;
        }

        private void dgvSetup()
        {
            if (FilesGridView.Columns.Count > 0)
            {
                FilesGridView.Columns[colFileName].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                FilesGridView.Columns[colNewName].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

    }
}
