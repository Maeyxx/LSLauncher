using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LSLauncher
{
    public partial class settingsLauncher : Form
    {
        mainLauncher mainLauncher = new mainLauncher();

        public settingsLauncher()
        {
            InitializeComponent();
        }

        private void settingsLauncher_Load(object sender, EventArgs e)
        {
            mainLauncher.LogInformation("opened " + this.Name);
            panelSettings.BackColor = Color.FromArgb(140, 0, 0, 0);
        }

        private void btnClearCache_Click(object sender, EventArgs e)
        {
            try
            {
                Directory.Delete(mainLauncher.config.AppSettings.Settings["fivemPath"].Value + @"\FiveM.app\data", true);
                mainLauncher.LogInformation("has cleared completed cache");
            }
            catch (Exception ex)
            {
                mainLauncher.LogError(ex);
            }
        }

        private void btnClearCacheLights_Click(object sender, EventArgs e)
        {
            try
            {
                string[] foldersName = { "cache", "nui-storage", "server-cache", "server-cache-priv" };

                string mainPath = mainLauncher.config.AppSettings.Settings["fivemPath"].Value + @"\FiveM.app\data\";

                foreach (string folder in foldersName)
                {
                    Directory.Delete(mainPath + "\\" + folder, true);
                    mainLauncher.LogInformation("has cleared by light cache from " + this.Name + " folder delete : " + folder);
                    MessageBox.Show("Cache has been cleared");
                }
            }
            catch (Exception ex)
            {
                mainLauncher.LogError(ex);
            }
        }

        private void btnClearLogs_Click(object sender, EventArgs e)
        {
            if (File.Exists(mainLauncher.logPath))
            {
                using (StreamWriter writer = File.CreateText(mainLauncher.logPath))
                {
                    writer.WriteLine("{0} File Log has been cleared", DateTime.Now);
                }

                MessageBox.Show("Log has been cleared");
            }
            else
            {
                MessageBox.Show("No logs file exist");

            }
        }

        private void btnClearLogs_MouseEnter(object sender, EventArgs e)
        {
            btnClearLogs.Font = new Font("Calibri", 10);
        }

        private void btnClearLogs_MouseLeave(object sender, EventArgs e)
        {
            btnClearLogs.Font = new Font("Calibri", 9);

        }

        private void btnClearCacheLights_MouseEnter(object sender, EventArgs e)
        {
            btnClearCacheLights.Font = new Font("Calibri", 10);
        }

        private void btnClearCacheLights_MouseLeave(object sender, EventArgs e)
        {
            btnClearCacheLights.Font = new Font("Calibri", 9);
        }

        private void btnClearCacheComplete_MouseEnter(object sender, EventArgs e)
        {
            btnClearCacheComplete.Font = new Font("Calibri", 10);
        }

        private void btnClearCacheComplete_MouseLeave(object sender, EventArgs e)
        {
            btnClearCacheComplete.Font = new Font("Calibri", 9);
        }

        private void btnOpenLogs_MouseEnter(object sender, EventArgs e)
        {
            btnOpenLogs.Font = new Font("Calibri", 10);
        }

        private void btnOpenLogs_MouseLeave(object sender, EventArgs e)
        {
            btnOpenLogs.Font = new Font("Calibri", 9);
        }

        private void btnOpenLogs_Click(object sender, EventArgs e)
        {
            Process.Start(mainLauncher.logPath);
            mainLauncher.LogInformation("opened logs");
        }

        private void btnChangePath_Click(object sender, EventArgs e)
        {
            mainLauncher.LogInformation("opened path changer");
            mainLauncher.config.AppSettings.Settings["firstOpenLauncher"].Value = Convert.ToString(0);
            mainLauncher.config.Save();
            LauncherSelectingPath launcherSelecting = new LauncherSelectingPath();
            launcherSelecting.Show();
        }

        private void btnChangePath_MouseEnter(object sender, EventArgs e)
        {
            btnChangePath.Font = new Font("Calibri", 10);
        }

        private void btnChangePath_MouseLeave(object sender, EventArgs e)
        {
            btnChangePath.Font = new Font("Calibri", 9);
        }
    }
}
