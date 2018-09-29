namespace FileRenamer
{
    partial class UI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSelPath = new System.Windows.Forms.Button();
            this.btnCommitRename = new System.Windows.Forms.Button();
            this.FilesGridView = new System.Windows.Forms.DataGridView();
            this.lblPath = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.FilesGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSelPath
            // 
            this.btnSelPath.Location = new System.Drawing.Point(12, 9);
            this.btnSelPath.Name = "btnSelPath";
            this.btnSelPath.Size = new System.Drawing.Size(75, 23);
            this.btnSelPath.TabIndex = 0;
            this.btnSelPath.Text = "Select Path";
            this.btnSelPath.UseVisualStyleBackColor = true;
            this.btnSelPath.Click += new System.EventHandler(this.btnSelPath_Click);
            // 
            // btnCommitRename
            // 
            this.btnCommitRename.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCommitRename.Location = new System.Drawing.Point(622, 9);
            this.btnCommitRename.Name = "btnCommitRename";
            this.btnCommitRename.Size = new System.Drawing.Size(105, 23);
            this.btnCommitRename.TabIndex = 3;
            this.btnCommitRename.Text = "Commit Rename";
            this.btnCommitRename.UseVisualStyleBackColor = true;
            this.btnCommitRename.Click += new System.EventHandler(this.btnCommitRename_Click);
            // 
            // FilesGridView
            // 
            this.FilesGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FilesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FilesGridView.Location = new System.Drawing.Point(12, 38);
            this.FilesGridView.Name = "FilesGridView";
            this.FilesGridView.Size = new System.Drawing.Size(715, 570);
            this.FilesGridView.TabIndex = 5;
            this.FilesGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // lblPath
            // 
            this.lblPath.AutoSize = true;
            this.lblPath.Location = new System.Drawing.Point(94, 14);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(91, 13);
            this.lblPath.TabIndex = 6;
            this.lblPath.Text = "No Path Selected";
            // 
            // UI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 620);
            this.Controls.Add(this.lblPath);
            this.Controls.Add(this.FilesGridView);
            this.Controls.Add(this.btnCommitRename);
            this.Controls.Add(this.btnSelPath);
            this.Name = "UI";
            this.Text = "File Renamer";
            this.Load += new System.EventHandler(this.UI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FilesGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSelPath;
        private System.Windows.Forms.Button btnCommitRename;
        private System.Windows.Forms.DataGridView FilesGridView;
        private System.Windows.Forms.Label lblPath;
    }
}

