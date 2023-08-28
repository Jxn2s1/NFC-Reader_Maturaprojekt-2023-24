namespace NFC_Reader
{
    partial class Upload
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
            cmd_upload_DB = new Button();
            Grid_Nfc_Upload = new DataGridView();
            cmd_download_DB = new Button();
            menuStrip1 = new MenuStrip();
            dateiToolStripMenuItem = new ToolStripMenuItem();
            reloadToolStripMenuItem = new ToolStripMenuItem();
            backToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            Delete_DB = new Button();
            cmd_Delete = new Button();
            cmd_Delete_All = new Button();
            ((System.ComponentModel.ISupportInitialize)Grid_Nfc_Upload).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // cmd_upload_DB
            // 
            cmd_upload_DB.Location = new Point(43, 253);
            cmd_upload_DB.Name = "cmd_upload_DB";
            cmd_upload_DB.Size = new Size(82, 36);
            cmd_upload_DB.TabIndex = 0;
            cmd_upload_DB.Text = "Upload DB";
            cmd_upload_DB.UseVisualStyleBackColor = true;
            cmd_upload_DB.Click += cmd_upload_DB_Click;
            // 
            // Grid_Nfc_Upload
            // 
            Grid_Nfc_Upload.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Grid_Nfc_Upload.Location = new Point(30, 41);
            Grid_Nfc_Upload.Name = "Grid_Nfc_Upload";
            Grid_Nfc_Upload.RowTemplate.Height = 25;
            Grid_Nfc_Upload.Size = new Size(334, 206);
            Grid_Nfc_Upload.TabIndex = 1;
            // 
            // cmd_download_DB
            // 
            cmd_download_DB.Location = new Point(157, 253);
            cmd_download_DB.Name = "cmd_download_DB";
            cmd_download_DB.Size = new Size(90, 36);
            cmd_download_DB.TabIndex = 2;
            cmd_download_DB.Text = "Download DB";
            cmd_download_DB.UseVisualStyleBackColor = true;
            cmd_download_DB.Click += cmd_download_DB_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { dateiToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // dateiToolStripMenuItem
            // 
            dateiToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { reloadToolStripMenuItem, backToolStripMenuItem, exitToolStripMenuItem });
            dateiToolStripMenuItem.Name = "dateiToolStripMenuItem";
            dateiToolStripMenuItem.Size = new Size(46, 20);
            dateiToolStripMenuItem.Text = "Datei";
            // 
            // reloadToolStripMenuItem
            // 
            reloadToolStripMenuItem.Name = "reloadToolStripMenuItem";
            reloadToolStripMenuItem.Size = new Size(110, 22);
            reloadToolStripMenuItem.Text = "Reload";
            reloadToolStripMenuItem.Click += reloadToolStripMenuItem_Click;
            // 
            // backToolStripMenuItem
            // 
            backToolStripMenuItem.Name = "backToolStripMenuItem";
            backToolStripMenuItem.Size = new Size(110, 22);
            backToolStripMenuItem.Text = "Back";
            backToolStripMenuItem.Click += backToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(110, 22);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(44, 20);
            helpToolStripMenuItem.Text = "Help";
            // 
            // Delete_DB
            // 
            Delete_DB.Location = new Point(383, 52);
            Delete_DB.Name = "Delete_DB";
            Delete_DB.Size = new Size(90, 36);
            Delete_DB.TabIndex = 4;
            Delete_DB.Text = "Delete DB";
            Delete_DB.UseVisualStyleBackColor = true;
            Delete_DB.Click += Delete_DB_Click;
            // 
            // cmd_Delete
            // 
            cmd_Delete.Location = new Point(383, 126);
            cmd_Delete.Name = "cmd_Delete";
            cmd_Delete.Size = new Size(90, 36);
            cmd_Delete.TabIndex = 5;
            cmd_Delete.Text = "Löschen";
            cmd_Delete.UseVisualStyleBackColor = true;
            cmd_Delete.Click += cmd_Delete_Click;
            // 
            // cmd_Delete_All
            // 
            cmd_Delete_All.Location = new Point(383, 191);
            cmd_Delete_All.Name = "cmd_Delete_All";
            cmd_Delete_All.Size = new Size(90, 36);
            cmd_Delete_All.TabIndex = 6;
            cmd_Delete_All.Text = "Alle Löschen";
            cmd_Delete_All.UseVisualStyleBackColor = true;
            cmd_Delete_All.Click += cmd_Delete_All_Click;
            // 
            // Upload
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cmd_Delete_All);
            Controls.Add(cmd_Delete);
            Controls.Add(Delete_DB);
            Controls.Add(cmd_download_DB);
            Controls.Add(Grid_Nfc_Upload);
            Controls.Add(cmd_upload_DB);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Upload";
            Text = "Upload";
            ((System.ComponentModel.ISupportInitialize)Grid_Nfc_Upload).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button cmd_upload_DB;
        private DataGridView Grid_Nfc_Upload;
        private Button cmd_download_DB;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem dateiToolStripMenuItem;
        private ToolStripMenuItem reloadToolStripMenuItem;
        private ToolStripMenuItem backToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private Button Delete_DB;
        private Button cmd_Delete;
        private Button cmd_Delete_All;
    }
}