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
using System.Configuration;
using System.Data.SQLite;

namespace BackUp
{
    public partial class BackUpForm : Form
    {
        public SQLiteConnection connection;
        public BackUpForm()
        {
            InitializeComponent();
        }

        private void BackUpForm_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.PerUserRoamingAndLocal);
            string path = Path.GetDirectoryName(config.FilePath);
            connection = new SQLiteConnection("Data Source = " + path + "\\Tracker.db" + ";Version = 3");
            if (File.Exists(path + "\\Tracker.db") == false)
                File.Copy(Application.StartupPath + "\\Tracker.db", path + "\\Tracker.db");
            connection.Open();
            UpdateTable();
        }
        private void UpdateTable()
        {
            DataTable table = GreenSQLite.GetTable("SELECT * FROM backups", connection);
            table.Columns.Add("Keep Watch", typeof(bool));
            foreach (DataRow row in table.Rows)
            {
                if (row["watch"].ToString() == "1")
                    row["Keep Watch"] = true;
                else
                    row["Keep Watch"] = false;
            }
            dataBackUps.DataSource = table;
            dataBackUps.Columns["id"].Visible = false;
            dataBackUps.Columns["watch"].Visible = false;
            dataBackUps.Columns["path"].HeaderText = "Path";
            dataBackUps.Columns["path"].ReadOnly = true;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtPath.Text != "")
            {
                if (Directory.Exists(txtPath.Text) == true)
                {
                    if (Settings.Default.KeepWatchOnAdd == true)
                        GreenSQLite.Execute("INSERT INTO backups (path, watch) VALUES('" + txtPath.Text + "', 1)", connection);
                    else
                        GreenSQLite.Execute("INSERT INTO backups (path, watch) VALUES('" + txtPath.Text + "', 0)", connection);
                    UpdateTable();
                }
                else if (MessageBox.Show("You are about to add a folder their does not exits, are you sure you want to add it?", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.Yes)
                {
                    if (Settings.Default.KeepWatchOnAdd == true)
                        GreenSQLite.Execute("INSERT INTO backups (path, watch) VALUES('" + txtPath.Text + "', 1)", connection);
                    else
                        GreenSQLite.Execute("INSERT INTO backups (path, watch) VALUES('" + txtPath.Text + "', 0)", connection);
                    UpdateTable();
                }
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
            btnDelete.Enabled = true;
        }

        private void dataBackUps_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (dataBackUps.SelectedRows.Count == 0)
            {
                btnOffOn.Enabled = false;
                btnOpen.Enabled = false;
                btnRestore.Enabled = false;
                btnDelete.Enabled = false;
            }
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

        private void dataBackUps_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if ((bool)dataBackUps.Rows[e.RowIndex].Cells["Keep Watch"].Value == true)
            {
                dataBackUps.Rows[e.RowIndex].Cells["watch"].Value = "1";
                GreenSQLite.Execute("UPDATE backups SET watch = 1 WHERE id = " + dataBackUps.Rows[e.RowIndex].Cells["id"].Value.ToString(), connection);
            }
            else
            {
                dataBackUps.Rows[e.RowIndex].Cells["watch"].Value = "0";
                GreenSQLite.Execute("UPDATE backups SET watch = 0 WHERE id = " + dataBackUps.Rows[e.RowIndex].Cells["id"].Value.ToString(), connection);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            GreenSQLite.Execute("DELETE FROM backups WHERE id = " + dataBackUps.SelectedRows[0].Cells["id"].Value.ToString(), connection);
            dataBackUps.Rows.RemoveAt(dataBackUps.SelectedRows[0].Index);
            if (dataBackUps.SelectedRows.Count == 0)
            {
                btnOffOn.Enabled = false;
                btnOpen.Enabled = false;
                btnRestore.Enabled = false;
                btnDelete.Enabled = false;
            }
        }

        private void dataBackUps_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Delete)
            {
                GreenSQLite.Execute("DELETE FROM backups WHERE id = " + dataBackUps.SelectedRows[0].Cells["id"].Value.ToString(), connection);
            }
        }
    }
}
