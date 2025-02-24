using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchiveManagerApp.Dao
{
    /* Le nom des bibliothèques pour le SGBD
        
        MySql       : MySql.Data.MySqlClient
        SQLServer   : System.Data.SqlClient
        Oracle      : Oracle.ManagedDataAccess.Client

        Il faut faire attention à la chaine de connection.
     */

    public class Connection
    {
        private static DbConnection _connection;
        static string server = "192.168.68.107";
        static string user = "sa";
        static string pwd = "Bird@1600";
        static string db = "facnet_mvp";
        static string port = "1433";

        public static DbConnection GetConnection()
        {
            if (_connection == null)
            {
                var connectionString = $"server={server},{port};user={user};password={pwd};database={db};MultipleActiveResultSets=True";


                try
                {
                    _connection = DbProviderFactories.GetFactory("System.Data.SqlClient").CreateConnection();
                    _connection.ConnectionString = connectionString;
                    _connection.Open();
                    Console.WriteLine("> Connection établie avec le serveur.");
                }
                catch (Exception ex)
                {
                    _connection = null;
                    Console.WriteLine($"> Impossible d'atteindre le serveur.\n{ex.Message}");
                }

            }
            return _connection;

        }
    }
}
