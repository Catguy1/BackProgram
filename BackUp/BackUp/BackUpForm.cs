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
using System.IO.Compression;

namespace BackUp
{
    public partial class BackUpForm : Form
    {
        public BackUpForm()
        {
            InitializeComponent();
        }

        private void BackUpForm_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            string[] listPath = Settings.Default.WatchListPath.Split(';');
            string[] listWatch = Settings.Default.WatchListKeepWatch.Split(';');
            DataTable table = new DataTable();
            table.Columns.Add("Path", typeof(string));
            table.Columns.Add("Keep Watch", typeof(bool));
            if (listPath != null)
            {
                for (int z = 0; z < listPath.Count(); z++)
                    if (listPath[z] != "")
                        table.Rows.Add(listPath[z], bool.Parse(listWatch[z]));
            }
            dataBackUps.DataSource = table;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(txtPath.Text) == true)
            {
                dataBackUps.Rows.Add(txtPath.Text, true);
                Settings.Default.WatchListPath += txtPath.Text + ";";
                Settings.Default.WatchListKeepWatch += "true;";
                Settings.Default.Save();
            }
        }

        private void btnOpenFolder_Click(object sender, EventArgs e)
        {
            if (openBD.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txtPath.Text = openBD.SelectedPath;
            }
        }

        private void dataBackUps_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            btnOffOn.Enabled = true;
            btnOpen.Enabled = true;
            btnRestore.Enabled = true;
        }

        private void dataBackUps_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            string[] listPath = Settings.Default.WatchListPath.Split(';');
            string[] listWatch = Settings.Default.WatchListKeepWatch.Split(';');
            listPath[e.RowIndex] = dataBackUps.Rows[e.RowIndex].Cells[0].Value.ToString();
            listWatch[e.RowIndex] = dataBackUps.Rows[e.RowIndex].Cells[1].Value.ToString();
            Settings.Default.WatchListPath = "";
            Settings.Default.WatchListKeepWatch = "";
            for (int z = 0; z < listPath.Count(); z++)
            {
                if (listPath[z] != "")
                {
                    Settings.Default.WatchListPath += listPath[z] + ";";
                    Settings.Default.WatchListKeepWatch += listWatch + ";";
                }
            }
            Settings.Default.Save();
            btnOffOn.Enabled = false;
            btnOpen.Enabled = false;
            btnRestore.Enabled = false;
        }

        private void toolOptions_Click(object sender, EventArgs e)
        {
            Options form = new Options();
            form.ShowDialog();
        }

        private void BackUpForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason != CloseReason.ApplicationExitCall)
            {
                e.Cancel = true;
                this.Hide();
            }
        }

        private void MenuIcon_DoubleClick(object sender, EventArgs e)
        {
            this.Show();
            this.Focus();
        }

        private void toolQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolQuit2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolShow_Click(object sender, EventArgs e)
        {
            this.Show();
            this.Focus();
        }

        private void dataBackUps_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            string[] listPath = Settings.Default.WatchListPath.Split(';');
            string[] listWatch = Settings.Default.WatchListKeepWatch.Split(';');
            listPath[e.RowIndex] = "";
            listWatch[e.RowIndex] = "";
            Settings.Default.WatchListPath = "";
            Settings.Default.WatchListKeepWatch = "";
            for (int z = 0; z < listPath.Count(); z++)
            {
                if (listPath[z] != "")
                {
                    Settings.Default.WatchListPath += listPath[z] + ";";
                    Settings.Default.WatchListKeepWatch += listWatch + ";";
                }
            }
            Settings.Default.Save();
        }
    }
}
