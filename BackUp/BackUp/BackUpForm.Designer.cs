namespace BackUp
{
    partial class BackUpForm
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
            connection.Close();
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BackUpForm));
            this.MenuIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.iconStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolShow = new System.Windows.Forms.ToolStripMenuItem();
            this.toolForceBackUp2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolQuit2 = new System.Windows.Forms.ToolStripMenuItem();
            this.dataBackUps = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.filesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolForceBackUp = new System.Windows.Forms.ToolStripMenuItem();
            this.toolQuit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnOffOn = new System.Windows.Forms.Button();
            this.txtLog = new System.Windows.Forms.RichTextBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnRestore = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.openBD = new System.Windows.Forms.FolderBrowserDialog();
            this.bgWorker = new System.ComponentModel.BackgroundWorker();
            this.btnOpenFolder = new System.Windows.Forms.Button();
<<<<<<< HEAD
            this.timer = new System.Windows.Forms.Timer(this.components);
=======
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
>>>>>>> 41cfa1563dec1eafc00aad9c32efa669ccec9c2f
            this.iconStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataBackUps)).BeginInit();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuIcon
            // 
            this.MenuIcon.ContextMenuStrip = this.iconStrip;
            this.MenuIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("MenuIcon.Icon")));
            this.MenuIcon.Text = "  BackUp 2015";
            this.MenuIcon.Visible = true;
            this.MenuIcon.DoubleClick += new System.EventHandler(this.MenuIcon_DoubleClick);
            // 
            // iconStrip
            // 
            this.iconStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolShow,
            this.toolForceBackUp2,
            this.toolStripSeparator1,
            this.toolQuit2});
            this.iconStrip.Name = "iconStrip";
            this.iconStrip.Size = new System.Drawing.Size(147, 76);
            // 
            // toolShow
            // 
            this.toolShow.Name = "toolShow";
            this.toolShow.Size = new System.Drawing.Size(146, 22);
            this.toolShow.Text = "Show";
            this.toolShow.Click += new System.EventHandler(this.toolShow_Click);
            // 
            // toolForceBackUp2
            // 
            this.toolForceBackUp2.Name = "toolForceBackUp2";
            this.toolForceBackUp2.Size = new System.Drawing.Size(146, 22);
            this.toolForceBackUp2.Text = "Force BackUp";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(143, 6);
            // 
            // toolQuit2
            // 
            this.toolQuit2.Name = "toolQuit2";
            this.toolQuit2.Size = new System.Drawing.Size(146, 22);
            this.toolQuit2.Text = "Quit";
            this.toolQuit2.Click += new System.EventHandler(this.toolQuit2_Click);
            // 
            // dataBackUps
            // 
            this.dataBackUps.AllowUserToAddRows = false;
            this.dataBackUps.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataBackUps.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataBackUps.Location = new System.Drawing.Point(9, 25);
            this.dataBackUps.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataBackUps.MultiSelect = false;
            this.dataBackUps.Name = "dataBackUps";
            this.dataBackUps.RowTemplate.Height = 24;
            this.dataBackUps.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataBackUps.Size = new System.Drawing.Size(496, 377);
            this.dataBackUps.TabIndex = 0;
            this.dataBackUps.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataBackUps_CellEndEdit);
            this.dataBackUps.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataBackUps_RowEnter);
            this.dataBackUps.RowLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataBackUps_RowLeave);
            this.dataBackUps.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataBackUps_KeyDown);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(840, 25);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(67, 28);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.toolTip1.SetToolTip(this.btnAdd, "Add the selected folder to the list of backups");
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filesToolStripMenuItem,
            this.toolOptions});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menu.Size = new System.Drawing.Size(914, 24);
            this.menu.TabIndex = 2;
            this.menu.Text = "menuStrip1";
            // 
            // filesToolStripMenuItem
            // 
            this.filesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolForceBackUp,
            this.toolQuit});
            this.filesToolStripMenuItem.Name = "filesToolStripMenuItem";
            this.filesToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.filesToolStripMenuItem.Text = "Files";
            // 
            // toolForceBackUp
            // 
            this.toolForceBackUp.Name = "toolForceBackUp";
            this.toolForceBackUp.Size = new System.Drawing.Size(145, 22);
            this.toolForceBackUp.Text = "Force Backup";
            // 
            // toolQuit
            // 
            this.toolQuit.Name = "toolQuit";
            this.toolQuit.Size = new System.Drawing.Size(145, 22);
            this.toolQuit.Text = "Quit";
            this.toolQuit.Click += new System.EventHandler(this.toolQuit_Click);
            // 
            // toolOptions
            // 
            this.toolOptions.Name = "toolOptions";
            this.toolOptions.Size = new System.Drawing.Size(61, 20);
            this.toolOptions.Text = "Options";
            this.toolOptions.Click += new System.EventHandler(this.toolOptions_Click);
            // 
            // txtPath
            // 
            this.txtPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPath.Location = new System.Drawing.Point(510, 25);
            this.txtPath.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(296, 28);
            this.txtPath.TabIndex = 3;
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.Location = new System.Drawing.Point(510, 58);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(397, 28);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete From BackUp List";
            this.toolTip1.SetToolTip(this.btnDelete, "Deletes the selected backup completely");
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnOffOn
            // 
            this.btnOffOn.Enabled = false;
            this.btnOffOn.Location = new System.Drawing.Point(510, 90);
            this.btnOffOn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnOffOn.Name = "btnOffOn";
            this.btnOffOn.Size = new System.Drawing.Size(397, 28);
            this.btnOffOn.TabIndex = 5;
            this.btnOffOn.Text = "Turn Off/On BackUp";
            this.toolTip1.SetToolTip(this.btnOffOn, "Stop/Start the backup of the selected folder");
            this.btnOffOn.UseVisualStyleBackColor = true;
            this.btnOffOn.Click += new System.EventHandler(this.btnOffOn_Click);
            // 
            // txtLog
            // 
            this.txtLog.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtLog.Location = new System.Drawing.Point(510, 208);
            this.txtLog.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.Size = new System.Drawing.Size(398, 195);
            this.txtLog.TabIndex = 6;
            this.txtLog.Text = "";
            // 
            // btnOpen
            // 
            this.btnOpen.Enabled = false;
            this.btnOpen.Location = new System.Drawing.Point(510, 123);
            this.btnOpen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(397, 28);
            this.btnOpen.TabIndex = 7;
            this.btnOpen.Text = "Open Place";
            this.toolTip1.SetToolTip(this.btnOpen, "Opens the location of the selected backup");
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnRestore
            // 
            this.btnRestore.Enabled = false;
            this.btnRestore.Location = new System.Drawing.Point(510, 155);
            this.btnRestore.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(397, 28);
            this.btnRestore.TabIndex = 8;
            this.btnRestore.Text = "Restore/Replace";
            this.toolTip1.SetToolTip(this.btnRestore, "Restore the selected folder using the backup");
            this.btnRestore.UseVisualStyleBackColor = true;
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(691, 185);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Log:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // openBD
            // 
            this.openBD.Description = "Select a folder you want to keep backup";
            // 
            // btnOpenFolder
            // 
            this.btnOpenFolder.Location = new System.Drawing.Point(810, 25);
            this.btnOpenFolder.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnOpenFolder.Name = "btnOpenFolder";
            this.btnOpenFolder.Size = new System.Drawing.Size(26, 28);
            this.btnOpenFolder.TabIndex = 10;
            this.btnOpenFolder.Text = "+";
            this.toolTip1.SetToolTip(this.btnOpenFolder, "Select a folder to backup");
            this.btnOpenFolder.UseVisualStyleBackColor = true;
            this.btnOpenFolder.Click += new System.EventHandler(this.btnOpenFolder_Click);
            // 
            // BackUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 412);
            this.Controls.Add(this.btnOpenFolder);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRestore);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.btnOffOn);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dataBackUps);
            this.Controls.Add(this.menu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menu;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "BackUpForm";
            this.Text = "BackUp 2015";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BackUpForm_FormClosing);
            this.Load += new System.EventHandler(this.BackUpForm_Load);
            this.iconStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataBackUps)).EndInit();
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon MenuIcon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRestore;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.RichTextBox txtLog;
        private System.Windows.Forms.Button btnOffOn;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dataBackUps;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem filesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolForceBackUp;
        private System.Windows.Forms.ToolStripMenuItem toolQuit;
        private System.Windows.Forms.ToolStripMenuItem toolOptions;
        private System.Windows.Forms.FolderBrowserDialog openBD;
        private System.Windows.Forms.ContextMenuStrip iconStrip;
        private System.Windows.Forms.ToolStripMenuItem toolForceBackUp2;
        private System.Windows.Forms.ToolStripMenuItem toolQuit2;
        private System.ComponentModel.BackgroundWorker bgWorker;
        private System.Windows.Forms.Button btnOpenFolder;
        private System.Windows.Forms.ToolStripMenuItem toolShow;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
<<<<<<< HEAD
        private System.Windows.Forms.Timer timer;
=======
        private System.Windows.Forms.ToolTip toolTip1;
>>>>>>> 41cfa1563dec1eafc00aad9c32efa669ccec9c2f
    }
}

