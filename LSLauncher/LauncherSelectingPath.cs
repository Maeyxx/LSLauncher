using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LSLauncher
{
    public partial class LauncherSelectingPath : Form
    {
        OpenFileDialog fileDialog = new OpenFileDialog();
        FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();

        public LauncherSelectingPath()
        {
            InitializeComponent();
        }

        private void LauncherSelectingPath_Load(object sender, EventArgs e)
        {
            panelMainChangerPath.BackColor = Color.FromArgb(120, 0, 0, 0);
            lblPathDiscord.Text = "Chemin d\'accès vers discord (.exe)";
            lblPathTeamspeak.Text = "Chemin d\'accès vers teamspeak (.exe)";
            lblPathFivem.Text = "Chemin d\'accès vers FiveM (le dossier où se trouve le .exe)";
            lblPathScreenshotSteam.Text = "Chemin d\'accès vers le dossier steam des screenshots";

            /*
             * GET values by app.config
             */
            txtBoxPathDiscord.Text = mainLauncher.config.AppSettings.Settings["discordPath"].Value;
            txtBoxPathFivem.Text = mainLauncher.config.AppSettings.Settings["fivemPath"].Value;
            txtBoxPathScreenshotSteam.Text = mainLauncher.config.AppSettings.Settings["screenshotPath"].Value;
            txtBoxPathTeamspeak.Text = mainLauncher.config.AppSettings.Settings["teamspeakPath"].Value;

            /* 
             * Open a new instance of fiveM with the connection to the ls-five.fr server by the powershell executable
             */

            /*
            Process cmd = new Process();
            cmd.StartInfo.FileName = "powershell";
            cmd.StartInfo.CreateNoWindow = true;
            cmd.StartInfo.UseShellExecute = true;
            cmd.Start();
            cmd.StandardInput.WriteLine("start fivem://connect/ls-five.fr");
            cmd.StandardInput.Flush();
            cmd.StandardInput.Close();
            cmd.WaitForExit();*/

        }

        private void btnPathDiscord_Click(object sender, EventArgs e)
        {

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                txtBoxPathDiscord.Text = fileDialog.InitialDirectory + fileDialog.FileName;
            }
        }

        private void btnSavePath_Click(object sender, EventArgs e)
        {
            var dialogResult = MessageBox.Show("En enregistrant ces données vous assurer de la bonne correspondance de celles-ci. Dans quel cas des dysfonctionnements peuvent arriver.", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            if (dialogResult == DialogResult.OK)
            {
                if (!String.IsNullOrEmpty(txtBoxPathDiscord.Text))
                {
                    if (!String.IsNullOrEmpty(txtBoxPathFivem.Text))
                    {
                        if (!String.IsNullOrEmpty(txtBoxPathScreenshotSteam.Text))
                        {
                            if (!String.IsNullOrEmpty(txtBoxPathTeamspeak.Text))
                            {
                                /*
                                 * 
                                 * Save data file into App.config of launcher.
                                 * Save path of :
                                 *  - FiveM, Discord, Teamspeak, screenshots path steam
                                 *  
                                 *  
                                 */

                                Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                                config.AppSettings.Settings["discordPath"].Value = txtBoxPathDiscord.Text;
                                config.AppSettings.Settings["fivemPath"].Value = txtBoxPathFivem.Text;
                                config.AppSettings.Settings["fivemExe"].Value = txtBoxPathFivem.Text + @"\FiveM.exe";
                                config.AppSettings.Settings["screenshotPath"].Value = txtBoxPathScreenshotSteam.Text;
                                config.AppSettings.Settings["teamspeakPath"].Value = txtBoxPathTeamspeak.Text;
                                config.AppSettings.Settings["firstOpenLauncher"].Value = Convert.ToString(1);
                                config.Save();

                                this.Close();

                                string exe = Environment.CurrentDirectory + @"\LSLauncher.exe";
                                Process.Start(exe);
                            }
                            else
                            {
                                MessageBox.Show("Aucun chemin d'accès spécifié pour teamspeak", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Aucun chemin d'accès spécifié pour les captures d'écrans steam", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Aucun chemin d'accès spécifié pour fiveM", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Aucun chemin d'accès spécifié pour discord", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnTeamspeak_Click(object sender, EventArgs e)
        {

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                txtBoxPathTeamspeak.Text = fileDialog.InitialDirectory + fileDialog.FileName;
            }
        }

        private void btnPathFivem_Click(object sender, EventArgs e)
        {

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                txtBoxPathFivem.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void btnPathScreenshotSteam_Click(object sender, EventArgs e)
        {

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                txtBoxPathScreenshotSteam.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void btnSavePath_MouseEnter(object sender, EventArgs e)
        {
            btnSavePath.Font = new Font("Calibri", 15, FontStyle.Bold);

        }

        private void btnSavePath_MouseLeave(object sender, EventArgs e)
        {
            btnSavePath.Font = new Font("Calibri", 14, FontStyle.Bold);
        }

        private void panelMainChangerPath_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pcBoxPathDiscord_MouseHover(object sender, EventArgs e)
        {
            toolTipPathDefault.SetToolTip(pcBoxPathDiscord, "Le chemin par défaut est : " + @"C:\Users\" + Environment.UserName + @"\AppData\Local\Discord");
        }

        private void pcBoxPathTeamspeak_MouseHover(object sender, EventArgs e)
        {
            toolTipPathDefault.SetToolTip(pcBoxPathTeamspeak, "Le chemin par défaut est : " + @"C:\Program Files\TeamSpeak 3 Client");
        }

        private void pcBoxPathFivem_MouseHover(object sender, EventArgs e)
        {
            toolTipPathDefault.SetToolTip(pcBoxPathFivem, "Le chemin par défaut est : " + @"C:\Users\" + Environment.UserName + @"\AppData\Local\FiveM");
        }

        private void pcBoxPathScreenshotSteam_MouseHover(object sender, EventArgs e)
        {
            toolTipPathDefault.SetToolTip(pcBoxPathScreenshotSteam, "Le chemin par défaut est : " + @"C:\Program Files (x86)\Steam\userdata\1094540254\760\remote\218\screenshots");
        }
    }
}
