using ArchiveManagerApp.Dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            DbConfig.DbName = ArchiveManagerApp.Properties.Settings.Default.local_dbname;
            DbConfig.DbUser = ArchiveManagerApp.Properties.Settings.Default.local_user;
            DbConfig.DbPassword = ArchiveManagerApp.Properties.Settings.Default.local_pwd;
            DbConfig.ServerName = ArchiveManagerApp.Properties.Settings.Default.local_server;
            DbConfig.DbPort = ArchiveManagerApp.Properties.Settings.Default.local_port;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormMain());
        }
    }
}
