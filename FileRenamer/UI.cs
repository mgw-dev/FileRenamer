using System;
using System.IO;
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

        private DirectoryInfo selectedDirectory;

        private void btnSelPath_Click(object sender, EventArgs e)
        {
            using (var cfDialog = new CommonOpenFileDialog())
            {
                cfDialog.IsFolderPicker = true;

                DialogResult dr = (DialogResult) cfDialog.ShowDialog();

                if (dr == DialogResult.OK)
                {
                    selectedDirectory = new DirectoryInfo(cfDialog.FileName);
                    lblPath.Text = $"Path: {cfDialog.FileName}\\";
                }
            }

            if (selectedDirectory != null)
            {
                FillDataGrid(selectedDirectory.GetFiles());
            }

        }

        private void btnCommitRename_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < FilesGridView.RowCount; i++)
            {
                if (Convert.ToBoolean(FilesGridView.Rows[i].Cells[1].Value))
                {
                    File.Move($"{selectedDirectory}\\{FilesGridView.Rows[i].Cells[0].Value}", $"{selectedDirectory}\\{FilesGridView.Rows[i].Cells[2].Value}");
                    FilesGridView.Rows[i].Cells[0].Value = FilesGridView.Rows[i].Cells[2].Value;
                }
            }
            //FillDataGrid(selectedDirectory.GetFiles());
        }

        void FillDataGrid(FileInfo[] Files)
        {
            FilesGridView.Rows.Clear();
            foreach (FileInfo fileInfo in Files)
            {
                int r = FilesGridView.Rows.Add();
                FilesGridView.Rows[r].Cells[0].Value = fileInfo.Name;
                FilesGridView.Rows[r].Cells[2].Value = fileInfo.Name;
            }
        }

        private void SetupDataGrid()
        {
            DataGridViewTextBoxColumn oldNameColumn = new DataGridViewTextBoxColumn()
            {
                HeaderText = "Files:",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            };

            DataGridViewCheckBoxColumn cbColumn = new DataGridViewCheckBoxColumn()
            {
                HeaderText = "Rename?",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            };

            DataGridViewTextBoxColumn newNameColumn = new DataGridViewTextBoxColumn()
            {
                HeaderText = "New Name:",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            };

            FilesGridView.Columns.Add(oldNameColumn);
            FilesGridView.Columns.Add(cbColumn);
            FilesGridView.Columns.Add(newNameColumn);

            FilesGridView.Columns[0].ReadOnly = true;
            FilesGridView.AllowUserToAddRows = false;
            FilesGridView.AllowUserToDeleteRows = false;
        }

        private void UI_Load(object sender, EventArgs e)
        {
            SetupDataGrid();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
