namespace NFC_Reader
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            dateiToolStripMenuItem = new ToolStripMenuItem();
            reloadToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            creatorToolStripMenuItem = new ToolStripMenuItem();
            cmd_Website = new Button();
            cmd_delete = new Button();
            cmd_delete_all = new Button();
            button1 = new Button();
            cmd_Upload_Database = new Button();
            button2 = new Button();
            grid_Nfc = new DataGridView();
            btn_exit = new Button();
            lbl_heading_1 = new Label();
            pB_Riselogo_1 = new PictureBox();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grid_Nfc).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pB_Riselogo_1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { dateiToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // dateiToolStripMenuItem
            // 
            dateiToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { reloadToolStripMenuItem, exitToolStripMenuItem });
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
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(110, 22);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { creatorToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(44, 20);
            helpToolStripMenuItem.Text = "Help";
            // 
            // creatorToolStripMenuItem
            // 
            creatorToolStripMenuItem.Name = "creatorToolStripMenuItem";
            creatorToolStripMenuItem.Size = new Size(113, 22);
            creatorToolStripMenuItem.Text = "Creator";
            creatorToolStripMenuItem.Click += creatorToolStripMenuItem_Click;
            // 
            // cmd_Website
            // 
            cmd_Website.Location = new Point(370, 70);
            cmd_Website.Name = "cmd_Website";
            cmd_Website.Size = new Size(75, 40);
            cmd_Website.TabIndex = 2;
            cmd_Website.Text = "Website";
            cmd_Website.UseVisualStyleBackColor = true;
            cmd_Website.Click += cmd_Website_Click;
            // 
            // cmd_delete
            // 
            cmd_delete.Location = new Point(370, 174);
            cmd_delete.Name = "cmd_delete";
            cmd_delete.Size = new Size(75, 40);
            cmd_delete.TabIndex = 4;
            cmd_delete.Text = "Löschen";
            cmd_delete.UseVisualStyleBackColor = true;
            cmd_delete.Click += cmd_delete_Click;
            // 
            // cmd_delete_all
            // 
            cmd_delete_all.Location = new Point(370, 122);
            cmd_delete_all.Name = "cmd_delete_all";
            cmd_delete_all.Size = new Size(75, 40);
            cmd_delete_all.TabIndex = 5;
            cmd_delete_all.Text = "Alle Löschen";
            cmd_delete_all.UseVisualStyleBackColor = true;
            cmd_delete_all.Click += cmd_delete_all_Click;
            // 
            // button1
            // 
            button1.Location = new Point(713, 386);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 6;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // cmd_Upload_Database
            // 
            cmd_Upload_Database.Location = new Point(370, 225);
            cmd_Upload_Database.Name = "cmd_Upload_Database";
            cmd_Upload_Database.Size = new Size(75, 40);
            cmd_Upload_Database.TabIndex = 7;
            cmd_Upload_Database.Text = "Upload";
            cmd_Upload_Database.UseVisualStyleBackColor = true;
            cmd_Upload_Database.Click += cmd_Upload_Database_Click;
            // 
            // button2
            // 
            button2.Location = new Point(713, 415);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 8;
            button2.Text = "Datenbank";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // grid_Nfc
            // 
            grid_Nfc.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grid_Nfc.Location = new Point(30, 70);
            grid_Nfc.Name = "grid_Nfc";
            grid_Nfc.RowTemplate.Height = 25;
            grid_Nfc.Size = new Size(335, 250);
            grid_Nfc.TabIndex = 9;
            // 
            // btn_exit
            // 
            btn_exit.Location = new Point(370, 280);
            btn_exit.Name = "btn_exit";
            btn_exit.Size = new Size(75, 40);
            btn_exit.TabIndex = 10;
            btn_exit.Text = "Close";
            btn_exit.UseVisualStyleBackColor = true;
            btn_exit.Click += btn_exit_Click;
            // 
            // lbl_heading_1
            // 
            lbl_heading_1.AutoSize = true;
            lbl_heading_1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_heading_1.Location = new Point(30, 24);
            lbl_heading_1.Name = "lbl_heading_1";
            lbl_heading_1.Size = new Size(154, 37);
            lbl_heading_1.TabIndex = 11;
            lbl_heading_1.Text = "Lokal Data";
            // 
            // pB_Riselogo_1
            // 
            pB_Riselogo_1.Image = Properties.Resources.rise_logo;
            pB_Riselogo_1.Location = new Point(30, 350);
            pB_Riselogo_1.Name = "pB_Riselogo_1";
            pB_Riselogo_1.Size = new Size(200, 90);
            pB_Riselogo_1.SizeMode = PictureBoxSizeMode.StretchImage;
            pB_Riselogo_1.TabIndex = 12;
            pB_Riselogo_1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pB_Riselogo_1);
            Controls.Add(lbl_heading_1);
            Controls.Add(btn_exit);
            Controls.Add(grid_Nfc);
            Controls.Add(button2);
            Controls.Add(cmd_Upload_Database);
            Controls.Add(button1);
            Controls.Add(cmd_delete_all);
            Controls.Add(cmd_delete);
            Controls.Add(cmd_Website);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)grid_Nfc).EndInit();
            ((System.ComponentModel.ISupportInitialize)pB_Riselogo_1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem dateiToolStripMenuItem;
        private ToolStripMenuItem reloadToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem creatorToolStripMenuItem;
        private Button cmd_Website;
        private Button cmd_delete;
        private Button cmd_delete_all;
        private Button button1;
        private Button cmd_Upload_Database;
        private Button button2;
        private DataGridView grid_Nfc;
        private Button btn_exit;
        private Button button3;
        private Label lbl_heading_1;
        private PictureBox pB_Riselogo_1;
    }
}