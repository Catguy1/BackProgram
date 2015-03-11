using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BackUp
{
    public partial class Options : Form
    {
        public Options()
        {
            InitializeComponent();
        }

        private void Options_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            txtBackUpLocation.Text = Settings.Default.BackUpFolder;
            barAmounts.Value = Settings.Default.BackVersionsKeep;
            rbComputerClosing.Checked = Settings.Default.UpdateByClose;
            rbComNone.Checked = Settings.Default.CompressNone;
            rbComRar.Checked = Settings.Default.CompressRar;
            rbComZip.Checked = Settings.Default.CompressZip;
            rbUdateManual.Checked = Settings.Default.UpdateByManual;
            rbUpdateInRegion.Checked = Settings.Default.UpdateByEdit;
            rbUpdateWhenTime.Checked = Settings.Default.UpdateByTime;
            rbTime.Checked = Settings.Default.UpdateByMins;
            chStart.Checked = Settings.Default.StartOnStartUp;
        }

        private void rbTime_CheckedChanged(object sender, EventArgs e)
        {
            if (rbTime.Checked == true)
                txtMin.Enabled = true;
            else
                txtMin.Enabled = false;
        }

        private void rbUpdateWhenTime_CheckedChanged(object sender, EventArgs e)
        {
            if (rbUpdateWhenTime.Checked == true)
            {
                txtHours.Enabled = true;
                txtMins.Enabled = true;
            }
            else
            {
                txtHours.Enabled = false;
                txtMins.Enabled = false;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(txtBackUpLocation.Text) == false)
            {
                if (MessageBox.Show("The backup save location does not exits, are you sure you want to save this location anyway?", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.Yes)
                {
                    Save();
                }
            }
            else
            {
                Save();
            }
        }
        private void Save()
        {
            
            Settings.Default.Save();
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }
        private void Options_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.DialogResult != System.Windows.Forms.DialogResult.OK)
                Settings.Default.Reload();
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void txtMin_TextChanged(object sender, EventArgs e)
        {
            for (int z = 0; z < txtMin.Text.Length; z++)
            {
                if (char.IsDigit(txtMin.Text[z]) == false)
                {
                    txtMin.Text = txtMin.Text.Replace(txtMin.Text[z].ToString(), "");
                    z--;
                }
            }
        }
    }
}
