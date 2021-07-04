

using Microsoft.Toolkit.Uwp.Notifications;
using System;
using System.Configuration;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace LSLauncher
{
    public partial class mainLauncher : Form
    {
        // Call the config file
        public static Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

        // Define log file
        public string logPath = config.AppSettings.Settings["fivemPath"].Value + @"\launcher\logs\logs.txt";
        public string appVersion = Application.ProductVersion;


        public mainLauncher()
        {
            InitializeComponent();
        }

        private void mainLauncher_Load(object sender, EventArgs e)
        {
            /* VARIBLES */
            this.Text = "LS - Launcher :: " + appVersion;
            string subPath = config.AppSettings.Settings["fivemPath"].Value + @"\\launcher\\logs";
            string existDirectory = config.AppSettings.Settings["fivemPath"].Value + @"launcher\logs";

            /* Modify component */
            notifyIconLSLauncher.Visible = false;
            toolStripTextBoxVersion.Enabled = false;
            toolStripTextBoxVersion.Text = "Version : " + appVersion;
            lblInformationProgressBar.Visible = false;
            panelProgressBar.BackColor = Color.FromArgb(90, 0, 0, 0);
            panelLeft.BackColor = Color.FromArgb(120, 0, 0, 0);
            panelRight.BackColor = Color.FromArgb(120, 0, 0, 0);
            panelMain.BackColor = Color.FromArgb(120, 0, 0, 0);
            lblMain.Text = "LS Launcher :: Version : " + appVersion;
            toolTipBtnPlay.SetToolTip(btnPlay, "Cliquez ici pour jouer");


            /* Conditional to create logs file & folder */
            if (!Directory.Exists(existDirectory))
            {
                Directory.CreateDirectory(config.AppSettings.Settings["fivemPath"].Value + @"\launcher");
                Directory.CreateDirectory(subPath);

                using (StreamWriter writer = File.CreateText(logPath))
                {
                    writer.WriteLine("{0} launch {1} to {2}", DateTime.Now, Application.ProductName, Environment.MachineName);
                }
            }
            else
            {
                using (StreamWriter writer = File.AppendText(logPath))
                {
                    writer.WriteLine("{0} launch {1} to {2}", DateTime.Now, Application.ProductName, Environment.MachineName);
                }
            }
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            string[] arrayAppName = { "Discord", "TeamSpeak", "FiveM" };
            lblInformationProgressBar.Text = "Chargement des applications...";
            lblInformationProgressBar.Visible = true;

            // Launch fiveM executable
            try
            {
                string appName = arrayAppName[0];
                Process.Start(config.AppSettings.Settings["discordPath"].Value);
                Thread.Sleep(5000);
                progressBarMain.Value = 33;
                lblInformationProgressBar.Text = "Lancement de " + appName;
                LogProcess(appName, config.AppSettings.Settings["discordPath"].Value);

            }
            catch (Exception ex)
            {
                LogError(ex);
            }

            try
            {
                string appName = arrayAppName[1];
                Process.Start(config.AppSettings.Settings["teamspeakPath"].Value);
                Thread.Sleep(3000);
                lblInformationProgressBar.Text = "Lancement de " + appName;
                progressBarMain.Value = 66;
                LogProcess(appName, config.AppSettings.Settings["teamspeakPath"].Value);

            }
            catch (Exception ex)
            {
                LogError(ex);

            }

            try
            {
                string appName = arrayAppName[2];
                Process.Start(config.AppSettings.Settings["fivemExe"].Value);
                progressBarMain.Value = 100;
                lblInformationProgressBar.Text = "Lancement de " + appName;
                LogProcess(appName, config.AppSettings.Settings["fivemExe"].Value);

            }
            catch (Exception ex)
            {
                LogError(ex);
            }

            lblInformationProgressBar.Text = "Applications lancées";


            Properties.Settings.Default.Save();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            settingsLauncher settingsLauncher = new settingsLauncher();
            settingsLauncher.Show();
        }

        private void btnWebSite_Click(object sender, EventArgs e)
        {
            LogInformation("opened law link");
            Process.Start("https://ls-five.jimdosite.com/");
        }


        private void btnOpenFileDialog_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.ShowDialog();

        }

        public void LogError(Exception exception)
        {
            using (StreamWriter writer = File.AppendText(logPath))
            {
                writer.WriteLine("{0} an error has occured from {1}. Error Message : {2}", DateTime.Now, this.Name, exception.Message);
            }
        }

        public void LogProcess(string appName, string path)
        {
            using (StreamWriter writer = File.AppendText(logPath))
            {
                writer.WriteLine("{0} user launch process {1} in {2}", DateTime.Now, appName, path);
            }
        }

        public void LogInformation(string contentText)
        {
            using (StreamWriter writer = File.AppendText(logPath))
            {
                writer.WriteLine("{0} user {1}", DateTime.Now, contentText);
            }
        }

        private void mainLauncher_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Hide();
                notifyIconLSLauncher.Visible = true;
                makeToast("LS-Launcher - information", "Vous avez réduit la fenêtre du launcher, celui-ci se trouve désormais dans la barre de notification.", "Fermer");

            }
            else if (this.WindowState == FormWindowState.Normal)
            {
                notifyIconLSLauncher.Visible = false;
            }
        }

        private void notifyIconLSLauncher_DoubleClick(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Show();
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                MessageBox.Show("Windows already open");
            }
        }

        private void makeToast(string title, string contentText)
        {
            string rootPath = Environment.CurrentDirectory;
            string iconPath = rootPath + @"\ressources\lsfive_320x320.png";

            new ToastContentBuilder()
                    .AddArgument("action", "viewConversation")
                    .AddArgument("conversationId", 9813)
                    .AddAppLogoOverride(new Uri(iconPath))
                    .AddText(title)
                    .AddText(contentText)
                    .SetToastDuration(ToastDuration.Short)
                    .Show();
        }

        private void makeToast(string title, string contentText, string buttonTextOne)
        {
            string rootPath = Environment.CurrentDirectory;
            string iconPath = rootPath + @"\ressources\lsfive_320x320.png";

            new ToastContentBuilder()
                    .AddArgument("action", "viewConversation")
                    .AddArgument("conversationId", 9813)
                    .AddAppLogoOverride(new Uri(iconPath))
                    .AddText(title)
                    .AddText(contentText)
                    .AddButton(new ToastButton()
                      .SetContent(buttonTextOne)
                      .AddArgument("action", "close")
                      )
                    .SetToastDuration(ToastDuration.Short)
                    .Show();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Open and show normal application EVENT CLICK TOOLSTRIPMENU

            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Show();
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Close application EVENT CLICK TOOLSTRIPMENU

            this.Close();
        }

        private void btnPlay_MouseHover(object sender, EventArgs e)
        {
            btnPlay.BackgroundImage = Properties.Resources.image_2;
        }


        private void btnPlay_MouseEnter(object sender, EventArgs e)
        {
            btnPlay.BackgroundImage = Properties.Resources.image_2;
        }

        private void btnPlay_MouseLeave(object sender, EventArgs e)
        {
            btnPlay.BackgroundImage = null;
        }

        private void btnSettings_MouseEnter(object sender, EventArgs e)
        {
            btnSettings.Font = new Font("Calibri", 10);
        }

        private void btnSettings_MouseLeave(object sender, EventArgs e)
        {
            btnSettings.Font = new Font("Calibri", 9);
        }

        private void btnScreens_MouseEnter(object sender, EventArgs e)
        {
            btnScreens.Font = new Font("Calibri", 10);
        }

        private void btnScreens_MouseLeave(object sender, EventArgs e)
        {
            btnScreens.Font = new Font("Calibri", 9);
        }

        private void btnLaw_MouseEnter(object sender, EventArgs e)
        {
            btnLaw.Font = new Font("Calibri", 10);
        }

        private void btnLaw_MouseLeave(object sender, EventArgs e)
        {
            btnLaw.Font = new Font("Calibri", 9);
        }

        private void btnDiscord_MouseEnter(object sender, EventArgs e)
        {
            btnDiscord.Font = new Font("Calibri", 10);
        }

        private void btnDiscord_MouseLeave(object sender, EventArgs e)
        {
            btnDiscord.Font = new Font("Calibri", 9);
        }

        private void btnScreens_Click(object sender, EventArgs e)
        {
            LogInformation("opened screenshot path in " + config.AppSettings.Settings["screenshotPath"].Value);
            Process.Start("explorer.exe", config.AppSettings.Settings["screenshotPath"].Value);
        }

        private void btnDiscord_Click(object sender, EventArgs e)
        {
            LogInformation("opened discord link");
            Process.Start("https://discord.gg/Jm47XgcMAM");

        }

        private void toolTipBtnPlay_Popup(object sender, PopupEventArgs e)
        {

        }

        private void informationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            makeToast("Information", "Ce launcher à été développé par @rmfr");
        }
    }
}
