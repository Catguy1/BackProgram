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
using Shell32;
using IWshRuntimeLibrary;
using System.Diagnostics;

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
            if (Directory.Exists(path) == false)
            {
                Settings.Default.BackUpFolder = path;
                Settings.Default.Save();
            }
            if (System.IO.File.Exists(path + "\\Tracker.db") == false)
                System.IO.File.Copy(Application.StartupPath + "\\Tracker.db", path + "\\Tracker.db");
            SetWatchUp();
            connection = new SQLiteConnection("Data Source = " + path + "\\Tracker.db" + ";Version = 3");    
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
                if (GreenSQLite.GetTable("SELECT id FROM backups WHERE path = '" + txtPath.Text + "'", connection).Rows.Count == 0)
                {
                    if (Directory.Exists(txtPath.Text) == true)
                    {
                        int id = 0;
                        if (Settings.Default.KeepWatchOnAdd == true)
                            id = GreenSQLite.ExecuteScaler("INSERT INTO backups (path, watch) VALUES('" + txtPath.Text + "', 1)", connection);
                        else
                            id = GreenSQLite.ExecuteScaler("INSERT INTO backups (path, watch) VALUES('" + txtPath.Text + "', 0)", connection);
                        UpdateTable();
                        Directory.CreateDirectory(Settings.Default.BackUpFolder + "\\" + id.ToString());
                        AddTextToLog("New folder added to watch.");
                    }
                    else if (MessageBox.Show("You are about to add a folder their does not exits, are you sure you want to add it?", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.Yes)
                    {
                        int id = 0;
                        if (Settings.Default.KeepWatchOnAdd == true)
                            id = GreenSQLite.ExecuteScaler("INSERT INTO backups (path, watch) VALUES('" + txtPath.Text + "', 1)", connection);
                        else
                            id = GreenSQLite.ExecuteScaler("INSERT INTO backups (path, watch) VALUES('" + txtPath.Text + "', 0)", connection);
                        UpdateTable();
                        Directory.CreateDirectory(Settings.Default.BackUpFolder + "\\" + id.ToString());
                        AddTextToLog("New folder added to watch.");
                    }
                }
                else
                    MessageBox.Show("The path is allready on the list", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
        private void SetWatchUp()
        {
            if (Settings.Default.StartOnStartUp == true)
            {
                if (System.IO.File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Startup) + "\\BackUp 2015.lnk") == false)
                {
                    IWshShell_Class wsh = new IWshShell_Class();
                    IWshRuntimeLibrary.IWshShortcut shortcut = wsh.CreateShortcut(Environment.GetFolderPath(Environment.SpecialFolder.Startup) + "\\BackUp 2015.lnk") as IWshRuntimeLibrary.IWshShortcut;
                    shortcut.TargetPath = Application.StartupPath + "\\BackUp.exe";
                    shortcut.Save();
                }
            }
            else
            {
                if (System.IO.File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Startup) + "\\BackUp 2015.lnk") == true)
                    System.IO.File.Delete(Environment.GetFolderPath(Environment.SpecialFolder.Startup) + "\\BackUp 2015.lnk");
            }
            if (Settings.Default.UpdateByMins == true)
            {
                timer.Interval = Settings.Default.UpdateByMinsMins * 60000;
                timer.Enabled = true;
            }
            else if (Settings.Default.UpdateByTime == true)
            {
                timer.Interval = 30000;
                timer.Enabled = true;
            }
            else if (Settings.Default.UpdateByManual == true)
            {
                timer.Enabled = false;
            }
            else if (Settings.Default.UpdateByClose == true)
            {
                timer.Enabled = false;
            }
            else if (Settings.Default.UpdateByEdit == true)
            {
                timer.Enabled = false;
            }
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
            Directory.Delete(Settings.Default.BackUpFolder + "\\" + dataBackUps.SelectedRows[0].Cells["id"].Value.ToString(), true);
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
                Directory.Delete(Settings.Default.BackUpFolder + "\\" + dataBackUps.SelectedRows[0].Cells["id"].Value.ToString(), true);
                GreenSQLite.Execute("DELETE FROM backups WHERE id = " + dataBackUps.SelectedRows[0].Cells["id"].Value.ToString(), connection);
                if (dataBackUps.SelectedRows.Count == 0)
                {
                    btnOffOn.Enabled = false;
                    btnOpen.Enabled = false;
                    btnRestore.Enabled = false;
                    btnDelete.Enabled = false;
                }
            }
        }

        private void btnOffOn_Click(object sender, EventArgs e)
        {
            if ((bool)dataBackUps.SelectedRows[0].Cells["Keep Watch"].Value == true)
            {
                dataBackUps.SelectedRows[0].Cells["watch"].Value = "0";
                dataBackUps.SelectedRows[0].Cells["Keep Watch"].Value = false;
                GreenSQLite.Execute("UPDATE backups SET watch = 0 WHERE id = " + dataBackUps.SelectedRows[0].Cells["id"].Value.ToString(), connection);
            }
            else
            {
                dataBackUps.SelectedRows[0].Cells["watch"].Value = "1";
                dataBackUps.SelectedRows[0].Cells["Keep Watch"].Value = true;
                GreenSQLite.Execute("UPDATE backups SET watch = 1 WHERE id = " + dataBackUps.SelectedRows[0].Cells["id"].Value.ToString(), connection);
            }
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {

        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            Process.Start(Settings.Default.BackUpFolder + "\\" + dataBackUps.SelectedRows[0].Cells["id"].Value.ToString());
        }
        private void AddTextToLog(string text)
        {
            txtLog.Text += text + "\n";
            txtLog.SelectionStart = txtLog.Text.Length - 1;
            txtLog.ScrollToCaret();
        }
    }
}
