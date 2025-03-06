using ArchiveManagerApp.Dao.Helper;
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
    public class Connection
    {
        private static DbConnection _connection;
        public static DbConnection GetConnection()
        {
            if (_connection == null)
            {
                /* Chaine pour la connection au SGBD
                    SQLServer $"server={0};port={4};user={1};password={2};database={3}"
                    MySQL $"server={server},{port};user={user};password={pwd};database={db}"
                    Oracle ...
                */

                var connectionString = $"server={DbConfig.ServerName}," +
                    $"{DbConfig.DbPort};" +
                    $"user={DbConfig.DbUser};" +
                    $"password={DbConfig.DbPassword};" +
                    $"database={DbConfig.DbName}";

                try
                {
                    _connection = DbProviderFactories.GetFactory(DbConfig.Provider).CreateConnection();
                    _connection.ConnectionString = connectionString;
                    _connection.Open();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erreur de connection");
                    _connection = null;
                }
            }
            return _connection;
        }
        public static DbConnection GetNewConnection()
        {
            var connectionString = $"server={DbConfig.ServerName}," +
                    $"{DbConfig.DbPort};" +
                    $"user={DbConfig.DbUser};" +
                    $"password={DbConfig.DbPassword};" +
                    $"database={DbConfig.DbName}";
            try
            {
                var connection = DbProviderFactories.GetFactory(DbConfig.Provider).CreateConnection();

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
