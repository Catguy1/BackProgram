namespace BackUp
{
    partial class Options
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
            this.txtBackUpLocation = new System.Windows.Forms.TextBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.lblBackup = new System.Windows.Forms.Label();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.openBD = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBackUpWhy = new System.Windows.Forms.GroupBox();
            this.rbUdateManual = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMins = new System.Windows.Forms.TextBox();
            this.txtHours = new System.Windows.Forms.TextBox();
            this.rbUpdateWhenTime = new System.Windows.Forms.RadioButton();
            this.rbComputerClosing = new System.Windows.Forms.RadioButton();
            this.txtMin = new System.Windows.Forms.TextBox();
            this.rbUpdateInRegion = new System.Windows.Forms.RadioButton();
            this.rbTime = new System.Windows.Forms.RadioButton();
            this.barAmounts = new System.Windows.Forms.TrackBar();
            this.lblBackups = new System.Windows.Forms.Label();
            this.groupCompression = new System.Windows.Forms.GroupBox();
            this.rbComRar = new System.Windows.Forms.RadioButton();
            this.rbComZip = new System.Windows.Forms.RadioButton();
            this.rbComNone = new System.Windows.Forms.RadioButton();
            this.chStart = new System.Windows.Forms.CheckBox();
            this.lblCount = new System.Windows.Forms.Label();
            this.chKeepWatchOnAdd = new System.Windows.Forms.CheckBox();
            this.groupBackUpWhy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barAmounts)).BeginInit();
            this.groupCompression.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBackUpLocation
            // 
            this.txtBackUpLocation.Location = new System.Drawing.Point(123, 15);
            this.txtBackUpLocation.Name = "txtBackUpLocation";
            this.txtBackUpLocation.Size = new System.Drawing.Size(572, 22);
            this.txtBackUpLocation.TabIndex = 0;
            // 
            // lblBackup
            // 
            this.lblBackup.AutoSize = true;
            this.lblBackup.Location = new System.Drawing.Point(12, 15);
            this.lblBackup.Name = "lblBackup";
            this.lblBackup.Size = new System.Drawing.Size(105, 17);
            this.lblBackup.TabIndex = 1;
            this.lblBackup.Text = "BackUp Folder:";
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(701, 14);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 23);
            this.btnOpen.TabIndex = 2;
            this.btnOpen.Text = "+";
            this.btnOpen.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(616, 255);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(160, 61);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // groupBackUpWhy
            // 
            this.groupBackUpWhy.Controls.Add(this.rbUdateManual);
            this.groupBackUpWhy.Controls.Add(this.label1);
            this.groupBackUpWhy.Controls.Add(this.txtMins);
            this.groupBackUpWhy.Controls.Add(this.txtHours);
            this.groupBackUpWhy.Controls.Add(this.rbUpdateWhenTime);
            this.groupBackUpWhy.Controls.Add(this.rbComputerClosing);
            this.groupBackUpWhy.Controls.Add(this.txtMin);
            this.groupBackUpWhy.Controls.Add(this.rbUpdateInRegion);
            this.groupBackUpWhy.Controls.Add(this.rbTime);
            this.groupBackUpWhy.Location = new System.Drawing.Point(15, 43);
            this.groupBackUpWhy.Name = "groupBackUpWhy";
            this.groupBackUpWhy.Size = new System.Drawing.Size(761, 100);
            this.groupBackUpWhy.TabIndex = 4;
            this.groupBackUpWhy.TabStop = false;
            this.groupBackUpWhy.Text = "BackUp When:";
            // 
            // rbUdateManual
            // 
            this.rbUdateManual.AutoSize = true;
            this.rbUdateManual.Location = new System.Drawing.Point(230, 52);
            this.rbUdateManual.Name = "rbUdateManual";
            this.rbUdateManual.Size = new System.Drawing.Size(155, 21);
            this.rbUdateManual.TabIndex = 8;
            this.rbUdateManual.Text = "Update manual only";
            this.rbUdateManual.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(166, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(12, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = ":";
            // 
            // txtMins
            // 
            this.txtMins.Enabled = false;
            this.txtMins.Location = new System.Drawing.Point(184, 50);
            this.txtMins.MaxLength = 2;
            this.txtMins.Name = "txtMins";
            this.txtMins.Size = new System.Drawing.Size(24, 22);
            this.txtMins.TabIndex = 6;
            this.txtMins.Text = "00";
            this.txtMins.TextChanged += new System.EventHandler(this.NrOnly);
            this.txtMins.Leave += new System.EventHandler(this.txtMins_Leave);
            // 
            // txtHours
            // 
            this.txtHours.Enabled = false;
            this.txtHours.Location = new System.Drawing.Point(136, 50);
            this.txtHours.MaxLength = 2;
            this.txtHours.Name = "txtHours";
            this.txtHours.Size = new System.Drawing.Size(24, 22);
            this.txtHours.TabIndex = 5;
            this.txtHours.Text = "12";
            this.txtHours.TextChanged += new System.EventHandler(this.NrOnly);
            this.txtHours.Leave += new System.EventHandler(this.txtHours_Leave);
            // 
            // rbUpdateWhenTime
            // 
            this.rbUpdateWhenTime.AutoSize = true;
            this.rbUpdateWhenTime.Location = new System.Drawing.Point(6, 50);
            this.rbUpdateWhenTime.Name = "rbUpdateWhenTime";
            this.rbUpdateWhenTime.Size = new System.Drawing.Size(129, 21);
            this.rbUpdateWhenTime.TabIndex = 4;
            this.rbUpdateWhenTime.Text = "Update on time:";
            this.rbUpdateWhenTime.UseVisualStyleBackColor = true;
            this.rbUpdateWhenTime.CheckedChanged += new System.EventHandler(this.rbUpdateWhenTime_CheckedChanged);
            // 
            // rbComputerClosing
            // 
            this.rbComputerClosing.AutoSize = true;
            this.rbComputerClosing.Location = new System.Drawing.Point(458, 24);
            this.rbComputerClosing.Name = "rbComputerClosing";
            this.rbComputerClosing.Size = new System.Drawing.Size(223, 21);
            this.rbComputerClosing.TabIndex = 3;
            this.rbComputerClosing.Text = "Update when computer closing";
            this.rbComputerClosing.UseVisualStyleBackColor = true;
            // 
            // txtMin
            // 
            this.txtMin.Enabled = false;
            this.txtMin.Location = new System.Drawing.Point(380, 23);
            this.txtMin.MaxLength = 10;
            this.txtMin.Name = "txtMin";
            this.txtMin.Size = new System.Drawing.Size(72, 22);
            this.txtMin.TabIndex = 2;
            this.txtMin.Text = "120";
            this.txtMin.TextChanged += new System.EventHandler(this.NrOnly);
            this.txtMin.Leave += new System.EventHandler(this.txtMin_Leave);
            // 
            // rbUpdateInRegion
            // 
            this.rbUpdateInRegion.AutoSize = true;
            this.rbUpdateInRegion.Checked = true;
            this.rbUpdateInRegion.Location = new System.Drawing.Point(6, 23);
            this.rbUpdateInRegion.Name = "rbUpdateInRegion";
            this.rbUpdateInRegion.Size = new System.Drawing.Size(218, 21);
            this.rbUpdateInRegion.TabIndex = 1;
            this.rbUpdateInRegion.TabStop = true;
            this.rbUpdateInRegion.Text = "Update when change in folder";
            this.rbUpdateInRegion.UseVisualStyleBackColor = true;
            // 
            // rbTime
            // 
            this.rbTime.AutoSize = true;
            this.rbTime.Location = new System.Drawing.Point(230, 23);
            this.rbTime.Name = "rbTime";
            this.rbTime.Size = new System.Drawing.Size(144, 21);
            this.rbTime.TabIndex = 0;
            this.rbTime.Text = "Update every min:";
            this.rbTime.UseVisualStyleBackColor = true;
            this.rbTime.CheckedChanged += new System.EventHandler(this.rbTime_CheckedChanged);
            // 
            // barAmounts
            // 
            this.barAmounts.Location = new System.Drawing.Point(151, 264);
            this.barAmounts.Minimum = 1;
            this.barAmounts.Name = "barAmounts";
            this.barAmounts.Size = new System.Drawing.Size(104, 56);
            this.barAmounts.TabIndex = 5;
            this.barAmounts.Value = 1;
            this.barAmounts.Scroll += new System.EventHandler(this.barAmounts_Scroll);
            // 
            // lblBackups
            // 
            this.lblBackups.AutoSize = true;
            this.lblBackups.Location = new System.Drawing.Point(12, 264);
            this.lblBackups.Name = "lblBackups";
            this.lblBackups.Size = new System.Drawing.Size(133, 17);
            this.lblBackups.TabIndex = 6;
            this.lblBackups.Text = "Amount of backups:";
            // 
            // groupCompression
            // 
            this.groupCompression.Controls.Add(this.rbComRar);
            this.groupCompression.Controls.Add(this.rbComZip);
            this.groupCompression.Controls.Add(this.rbComNone);
            this.groupCompression.Location = new System.Drawing.Point(15, 149);
            this.groupCompression.Name = "groupCompression";
            this.groupCompression.Size = new System.Drawing.Size(761, 100);
            this.groupCompression.TabIndex = 7;
            this.groupCompression.TabStop = false;
            this.groupCompression.Text = "Compression Type";
            // 
            // rbComRar
            // 
            this.rbComRar.AutoSize = true;
            this.rbComRar.Enabled = false;
            this.rbComRar.Location = new System.Drawing.Point(136, 21);
            this.rbComRar.Name = "rbComRar";
            this.rbComRar.Size = new System.Drawing.Size(51, 21);
            this.rbComRar.TabIndex = 5;
            this.rbComRar.Text = ".rar";
            this.rbComRar.UseVisualStyleBackColor = true;
            // 
            // rbComZip
            // 
            this.rbComZip.AutoSize = true;
            this.rbComZip.Location = new System.Drawing.Point(75, 21);
            this.rbComZip.Name = "rbComZip";
            this.rbComZip.Size = new System.Drawing.Size(51, 21);
            this.rbComZip.TabIndex = 4;
            this.rbComZip.Text = ".zip";
            this.rbComZip.UseVisualStyleBackColor = true;
            // 
            // rbComNone
            // 
            this.rbComNone.AutoSize = true;
            this.rbComNone.Checked = true;
            this.rbComNone.Location = new System.Drawing.Point(6, 21);
            this.rbComNone.Name = "rbComNone";
            this.rbComNone.Size = new System.Drawing.Size(63, 21);
            this.rbComNone.TabIndex = 3;
            this.rbComNone.TabStop = true;
            this.rbComNone.Text = "None";
            this.rbComNone.UseVisualStyleBackColor = true;
            // 
            // chStart
            // 
            this.chStart.AutoSize = true;
            this.chStart.Checked = true;
            this.chStart.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chStart.Location = new System.Drawing.Point(15, 299);
            this.chStart.Name = "chStart";
            this.chStart.Size = new System.Drawing.Size(132, 21);
            this.chStart.TabIndex = 8;
            this.chStart.Text = "Start up on start";
            this.chStart.UseVisualStyleBackColor = true;
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(261, 268);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(16, 17);
            this.lblCount.TabIndex = 9;
            this.lblCount.Text = "1";
            // 
            // chKeepWatchOnAdd
            // 
            this.chKeepWatchOnAdd.AutoSize = true;
            this.chKeepWatchOnAdd.Checked = true;
            this.chKeepWatchOnAdd.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chKeepWatchOnAdd.Location = new System.Drawing.Point(153, 299);
            this.chKeepWatchOnAdd.Name = "chKeepWatchOnAdd";
            this.chKeepWatchOnAdd.Size = new System.Drawing.Size(151, 21);
            this.chKeepWatchOnAdd.TabIndex = 10;
            this.chKeepWatchOnAdd.Text = "Keep watch on add";
            this.chKeepWatchOnAdd.UseVisualStyleBackColor = true;
            // 
            // Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 330);
            this.Controls.Add(this.chKeepWatchOnAdd);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.chStart);
            this.Controls.Add(this.groupCompression);
            this.Controls.Add(this.lblBackups);
            this.Controls.Add(this.barAmounts);
            this.Controls.Add(this.groupBackUpWhy);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.lblBackup);
            this.Controls.Add(this.txtBackUpLocation);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Options";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Options";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Options_FormClosing);
            this.Load += new System.EventHandler(this.Options_Load);
            this.groupBackUpWhy.ResumeLayout(false);
            this.groupBackUpWhy.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barAmounts)).EndInit();
            this.groupCompression.ResumeLayout(false);
            this.groupCompression.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBackUpLocation;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Label lblBackup;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.FolderBrowserDialog openBD;
        private System.Windows.Forms.GroupBox groupBackUpWhy;
        private System.Windows.Forms.TextBox txtMin;
        private System.Windows.Forms.RadioButton rbUpdateInRegion;
        private System.Windows.Forms.RadioButton rbTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMins;
        private System.Windows.Forms.TextBox txtHours;
        private System.Windows.Forms.RadioButton rbUpdateWhenTime;
        private System.Windows.Forms.RadioButton rbComputerClosing;
        private System.Windows.Forms.TrackBar barAmounts;
        private System.Windows.Forms.Label lblBackups;
        private System.Windows.Forms.GroupBox groupCompression;
        private System.Windows.Forms.RadioButton rbComRar;
        private System.Windows.Forms.RadioButton rbComZip;
        private System.Windows.Forms.RadioButton rbComNone;
        private System.Windows.Forms.RadioButton rbUdateManual;
        private System.Windows.Forms.CheckBox chStart;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.CheckBox chKeepWatchOnAdd;
    }
}