using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ArchiveManagerApp.Util.Functions;
using System.Windows.Forms;
using ArchiveManagerApp.Model;
using Microsoft.Office.Interop.Word;
using System.Data.Common;

namespace ArchiveManagerApp.Dao.Helper
{
    public class ServerConfiguration
    {
        public string AdresseIP { get; set; }
        public string Port { get; set; }
        public string DataBase { get; set; }
        public string User { get; set; }
        public string PassWord { get; set; }

        public ServerConfiguration(string pathDataSource)
        {
            if (File.Exists(pathDataSource))
            {
                string[] sourceConfig = File.ReadAllLines(pathDataSource);
                AdresseIP = ExtractText(sourceConfig[0], ":");
                Port = ExtractText(sourceConfig[1], ":");
                DataBase = ExtractText(sourceConfig[2], ":");
                User = ExtractText(sourceConfig[3], ":");
                PassWord = ExtractText(sourceConfig[4], ":");
            }
            else
            {
                MessageBox.Show($"Impossible de trouver {pathDataSource} !");
            }
        }
        public DbConnection GetConnection()
        {
            DbConnection dbConnection;

            var connectionString = $"server={AdresseIP},{Port};user={User};password={PassWord};database={DataBase}";

            try
            {
                dbConnection = DbProviderFactories.GetFactory("MySql.Data.MySqlClient").CreateConnection();
                dbConnection.ConnectionString = connectionString;
                dbConnection.Open();
                MessageBox.Show("> Connection établie avec le serveur.");
            }
            catch (Exception ex)
            {
                dbConnection = null;
                MessageBox.Show($"> Connection Echouée.\n{ex.Message}");
            }
            return dbConnection;
        }
        public void TestConnection()
        {
            TestConnection(AdresseIP, Port, DataBase, User, PassWord);
        }
        public static void TestConnection(string adresseIP, string port, string dataBase, string user, string passWord)
        {
            DbConnection dbConnection;


            var connectionString = $"server={adresseIP},{port};user={user};password={passWord};database={dataBase}";

            try
            {
                dbConnection = DbProviderFactories.GetFactory("MySql.Data.MySqlClient").CreateConnection();
                dbConnection.ConnectionString = connectionString;
                dbConnection.Open();
                MessageBox.Show("> Connection établie avec le serveur.");
            }
            catch (Exception ex)
            {
                dbConnection = null;
                MessageBox.Show($"> Impossible d'atteindre le serveur.\n{ex.Message}");
            }
        }
        private static string ExtractText(string source, string from)
        {
            int indice = source.LastIndexOf(from);
            return source.Substring(indice).Trim();
        }
    }
}
