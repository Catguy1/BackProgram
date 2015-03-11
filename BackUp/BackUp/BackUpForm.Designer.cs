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
            this.iconStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolForceBackUp2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolQuit2 = new System.Windows.Forms.ToolStripMenuItem();
            this.bgWorker = new System.ComponentModel.BackgroundWorker();
            this.btnOpenFolder = new System.Windows.Forms.Button();
            this.toolShow = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            ((System.ComponentModel.ISupportInitialize)(this.dataBackUps)).BeginInit();
            this.menu.SuspendLayout();
            this.iconStrip.SuspendLayout();
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
            // dataBackUps
            // 
            this.dataBackUps.AllowUserToAddRows = false;
            this.dataBackUps.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataBackUps.Location = new System.Drawing.Point(12, 31);
            this.dataBackUps.MultiSelect = false;
            this.dataBackUps.Name = "dataBackUps";
            this.dataBackUps.RowTemplate.Height = 24;
            this.dataBackUps.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataBackUps.Size = new System.Drawing.Size(662, 464);
            this.dataBackUps.TabIndex = 0;
            this.dataBackUps.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataBackUps_RowEnter);
            this.dataBackUps.RowLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataBackUps_RowLeave);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(1120, 31);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(89, 34);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
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
            this.menu.Size = new System.Drawing.Size(1218, 28);
            this.menu.TabIndex = 2;
            this.menu.Text = "menuStrip1";
            // 
            // filesToolStripMenuItem
            // 
            this.filesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolForceBackUp,
            this.toolQuit});
            this.filesToolStripMenuItem.Name = "filesToolStripMenuItem";
            this.filesToolStripMenuItem.Size = new System.Drawing.Size(50, 24);
            this.filesToolStripMenuItem.Text = "Files";
            // 
            // toolForceBackUp
            // 
            this.toolForceBackUp.Name = "toolForceBackUp";
            this.toolForceBackUp.Size = new System.Drawing.Size(175, 24);
            this.toolForceBackUp.Text = "Force Backup";
            // 
            // toolQuit
            // 
            this.toolQuit.Name = "toolQuit";
            this.toolQuit.Size = new System.Drawing.Size(175, 24);
            this.toolQuit.Text = "Quit";
            this.toolQuit.Click += new System.EventHandler(this.toolQuit_Click);
            // 
            // toolOptions
            // 
            this.toolOptions.Name = "toolOptions";
            this.toolOptions.Size = new System.Drawing.Size(73, 24);
            this.toolOptions.Text = "Options";
            this.toolOptions.Click += new System.EventHandler(this.toolOptions_Click);
            // 
            // txtPath
            // 
            this.txtPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPath.Location = new System.Drawing.Point(680, 31);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(394, 34);
            this.txtPath.TabIndex = 3;
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.Location = new System.Drawing.Point(680, 71);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(529, 34);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete From BackUp List";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnOffOn
            // 
            this.btnOffOn.Enabled = false;
            this.btnOffOn.Location = new System.Drawing.Point(680, 111);
            this.btnOffOn.Name = "btnOffOn";
            this.btnOffOn.Size = new System.Drawing.Size(529, 34);
            this.btnOffOn.TabIndex = 5;
            this.btnOffOn.Text = "Turn Off/On BackUp";
            this.btnOffOn.UseVisualStyleBackColor = true;
            // 
            // txtLog
            // 
            this.txtLog.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtLog.Location = new System.Drawing.Point(680, 256);
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.Size = new System.Drawing.Size(529, 239);
            this.txtLog.TabIndex = 6;
            this.txtLog.Text = "";
            // 
            // btnOpen
            // 
            this.btnOpen.Enabled = false;
            this.btnOpen.Location = new System.Drawing.Point(680, 151);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(529, 34);
            this.btnOpen.TabIndex = 7;
            this.btnOpen.Text = "Open Place";
            this.btnOpen.UseVisualStyleBackColor = true;
            // 
            // btnRestore
            // 
            this.btnRestore.Enabled = false;
            this.btnRestore.Location = new System.Drawing.Point(680, 191);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(529, 34);
            this.btnRestore.TabIndex = 8;
            this.btnRestore.Text = "Restore/Replace";
            this.btnRestore.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(921, 228);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Log:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // openBD
            // 
            this.openBD.Description = "Select a folder you want to keep backup";
            // 
            // iconStrip
            // 
            this.iconStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolShow,
            this.toolForceBackUp2,
            this.toolStripSeparator1,
            this.toolQuit2});
            this.iconStrip.Name = "iconStrip";
            this.iconStrip.Size = new System.Drawing.Size(176, 110);
            // 
            // toolForceBackUp2
            // 
            this.toolForceBackUp2.Name = "toolForceBackUp2";
            this.toolForceBackUp2.Size = new System.Drawing.Size(175, 24);
            this.toolForceBackUp2.Text = "Force BackUp";
            // 
            // toolQuit2
            // 
            this.toolQuit2.Name = "toolQuit2";
            this.toolQuit2.Size = new System.Drawing.Size(175, 24);
            this.toolQuit2.Text = "Quit";
            this.toolQuit2.Click += new System.EventHandler(this.toolQuit2_Click);
            // 
            // btnOpenFolder
            // 
            this.btnOpenFolder.Location = new System.Drawing.Point(1080, 31);
            this.btnOpenFolder.Name = "btnOpenFolder";
            this.btnOpenFolder.Size = new System.Drawing.Size(34, 34);
            this.btnOpenFolder.TabIndex = 10;
            this.btnOpenFolder.Text = "+";
            this.btnOpenFolder.UseVisualStyleBackColor = true;
            this.btnOpenFolder.Click += new System.EventHandler(this.btnOpenFolder_Click);
            // 
            // toolShow
            // 
            this.toolShow.Name = "toolShow";
            this.toolShow.Size = new System.Drawing.Size(175, 24);
            this.toolShow.Text = "Show";
            this.toolShow.Click += new System.EventHandler(this.toolShow_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(172, 6);
            // 
            // BackUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1218, 507);
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
            this.MainMenuStrip = this.menu;
            this.MaximizeBox = false;
            this.Name = "BackUpForm";
            this.Text = "BackUp 2015";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BackUpForm_FormClosing);
            this.Load += new System.EventHandler(this.BackUpForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataBackUps)).EndInit();
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.iconStrip.ResumeLayout(false);
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
    }
}

