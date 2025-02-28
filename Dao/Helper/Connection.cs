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
        static string server = "127.0.0.1";
        static string user = "root";
        static string pwd = "hunterxhunterA1";
        static string db = "gestion_archivage_db";
        static string port = "3306";

        public static DbConnection GetConnection()
        {
            if (_connection == null)
            {
                //"server={0};user={1};password={2};database={3};port={4}"

                var connectionString = $"server={server},{port};user={user};password={pwd};database={db}";

                try
                {
                    _connection = DbProviderFactories.GetFactory("MySql.Data.MySqlClient").CreateConnection();
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
