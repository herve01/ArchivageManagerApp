using System;
using System.Collections.Generic;
using System.Data.Common;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArchiveManagerApp.Dao
{
    /* Le nom des bibliothèques pour le SGBD
        MySql       : MySql.Data.MySqlClient
        SQLServer   : System.Data.SqlClient
        Oracle      : Oracle.ManagedDataAccess.Client
     */

    public class Connection
    {
        private static DbConnection _connection;
        static string server = "127.0.0.1";
        static string user = "root";
        static string pwd = "hunterxhunterA1";
        static string db = "gestion_archivage_db";
        static string port = "3306";
        public static string provider = "MySql.Data.MySqlClient";
        
        public static DbConnection GetConnection()
        {
            if (_connection == null)
            {

                /* Chaine pour la connection au SGBD
                    SQLServer $"server={0};user={1};password={2};database={3};port={4}"
                    MySQL $"server={server},{port};user={user};password={pwd};database={db}"
                    Oracle ...
                */

                var connectionString = $"server={server},{port};user={user};password={pwd};database={db}";

                try
                {
                    _connection = DbProviderFactories.GetFactory(provider).CreateConnection();
                    _connection.ConnectionString = connectionString;
                    _connection.Open();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur de connection", ex.Message);
                    _connection = null;
                }
            }
            return _connection;
        }
        public static DbConnection GetNewConnection()
        {
            var connectionString = $"server={server},{port};user={user};password={pwd};database={db}";

            try
            {
                
                var connection = DbProviderFactories.GetFactory(provider).CreateConnection();
                connection.ConnectionString = connectionString;
                connection.Open();

                return connection;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur de connection");
                return null;
            } 
        }
    }
}
