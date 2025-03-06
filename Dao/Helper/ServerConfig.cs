using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Common;

namespace ArchiveManagerApp.Dao.Helper
{
    public class ServerConfig
    {
        public string Server;
        public string Port { get; set; }
        public string DataBase { get; set; }
        public string User { get; set; }
        public string Password { get; set; }
        public readonly string Provider = "MySql.Data.MySqlClient";
        public ServerConfig()
        {
            Server = Properties.Settings.Default.local_server;
            Port = Properties.Settings.Default.local_port;
            DataBase = Properties.Settings.Default.local_database;
            User = Properties.Settings.Default.local_user;
            Password = Properties.Settings.Default.local_password;
        }
        public DbConnection GetConnection()
        {
            return GetConnection(Server, Port, DataBase, User, Password);
        }
        public void TestConnection()
        {
            TestConnection(Server, Port, DataBase, User, Password);
        }
        public static void TestConnection(string server, string port, string dataBase, string user, string passWord)
        {
            DbConnection dbConnection;


            var connectionString = $"server={server},{port};user={user};password={passWord};database={dataBase}";

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
        public DbConnection GetConnection(string server, string port, string dataBase, string user, string passWord)
        {
            DbConnection dbConnection;

            var connectionString = $"server={Server},{Port};user={User};password={Password};database={DataBase}";

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
        public static async Task<List<string>> GetDatabases(DbConnection connection)
        {
            var list = new List<string>();

            try
            {
                var requete = connection.CreateCommand();
                requete.CommandText = "show databases";

                var reader = await requete.ExecuteReaderAsync();

                if (reader.HasRows)
                    while (reader.Read())
                        list.Add(reader["Database"].ToString());

                reader.Close();
            }
            catch (Exception)
            {
            }

            return list;
        }
        public static bool TestDatabase(DbConnection connection, string dbname)
        {
            try
            {
                var requete = connection.CreateCommand();
                requete.CommandText = "select * from " + dbname + ".gestion_archivage_db_info";

                var reader = requete.ExecuteReader();
                var exists = reader.HasRows;

                reader.Close();

                return exists;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
