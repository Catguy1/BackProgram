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
            txtHours.Text = Settings.Default.UpdateByTimeHours.ToString();
            txtMins.Text = Settings.Default.UpdateByTimeMins.ToString();
            txtMin.Text = Settings.Default.UpdateByMinsMins.ToString();
            chKeepWatchOnAdd.Checked = Settings.Default.KeepWatchOnAdd;
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
            Settings.Default.BackUpFolder = txtBackUpLocation.Text;
            Settings.Default.BackVersionsKeep = barAmounts.Value;
            Settings.Default.UpdateByClose = rbComputerClosing.Checked;
            Settings.Default.CompressNone = rbComNone.Checked;
            Settings.Default.CompressRar = rbComRar.Checked;
            Settings.Default.CompressZip = rbComZip.Checked;
            Settings.Default.UpdateByManual = rbUdateManual.Checked;
            Settings.Default.UpdateByEdit = rbUpdateInRegion.Checked;
            Settings.Default.UpdateByTime = rbUpdateWhenTime.Checked;
            Settings.Default.UpdateByMins = rbTime.Checked;
            Settings.Default.StartOnStartUp = chStart.Checked;
            Settings.Default.UpdateByTimeHours = int.Parse(txtHours.Text);
            Settings.Default.UpdateByTimeMins = int.Parse(txtMins.Text);
            Settings.Default.UpdateByMinsMins = int.Parse(txtMin.Text);
            Settings.Default.KeepWatchOnAdd = chKeepWatchOnAdd.Checked;
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

        private void NrOnly(object sender, EventArgs e)
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

        private void txtHours_Leave(object sender, EventArgs e)
        {
            if (txtHours.Text == "")
                txtHours.Text = "0";
            else if (int.Parse(txtHours.Text) > 24)
                txtHours.Text = "24";
            else if (int.Parse(txtHours.Text) < 0)
                txtHours.Text = "0";
        }

        private void txtMins_Leave(object sender, EventArgs e)
        {
            if (txtMins.Text == "")
                txtHours.Text = "0";
            else if (int.Parse(txtHours.Text) > 24)
                txtMins.Text = "0";
            if (int.Parse(txtMins.Text) < 0)
                txtMins.Text = "0";
            else if (int.Parse(txtMins.Text) > 59)
                txtMins.Text = "59";
        }

        private void txtMin_Leave(object sender, EventArgs e)
        {
            if (txtMin.Text == "" || int.Parse(txtMin.Text) == 0)
                txtMin.Text = "1";
        }

        private void barAmounts_Scroll(object sender, EventArgs e)
        {
            lblCount.Text = barAmounts.Value.ToString();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            if (openBD.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txtBackUpLocation.Text = openBD.SelectedPath;
            }
        }
    }
}
