using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LSLauncher
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            int firstOpenLauncherValue = Convert.ToInt32(config.AppSettings.Settings["firstOpenLauncher"].Value);

            if (firstOpenLauncherValue == 0)
            {
                Application.Run(new LauncherSelectingPath());
            }
            else
            {
                Application.Run(new mainLauncher());
            }
        }
    }
}
