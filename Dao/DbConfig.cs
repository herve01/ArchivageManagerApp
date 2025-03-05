using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchiveManagerApp.Dao
{
    public class DbConfig
    {
        public static string DbName { get; set; }
        public static string DbInvariant { get; set; }
        public static string DbPort { get; set; }
        public static string DbUser { get; set; }
        public static string DbPassword { get; set; }
        public static string ServerName { get; set; }

        /* Le nom des bibliothèques pour le SGBD
            MySql       : MySql.Data.MySqlClient
            SQLServer   : System.Data.SqlClient
            Oracle      : Oracle.ManagedDataAccess.Client
         */
        public static string Provider { get; set; } = "MySql.Data.MySqlClient";

    }
}
