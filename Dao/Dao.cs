using ArchiveManagerApp.Model.App;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArchiveManagerApp.Dao
{
    public abstract class Dao <T>
    {
        public abstract int Add(T instance);
        public abstract int Update(T instance);
        public abstract int Delete(T instance);

        protected abstract Dictionary<string, object> GetMapping(DbDataReader reader);

        protected DbConnection Connection;
        protected DbCommand Command;
        protected DbDataReader Reader;
        protected DbDataAdapter Adapter;

        protected string TableName = string.Empty;

        public Dao()
        {
            try
            {
                Connection = Dao.Connection.GetConnection();
                Command = Connection.CreateCommand();
                Adapter = DbProviderFactories.GetFactory("MySql.Data.MySqlClient").CreateDataAdapter();

                if (Connection.State == System.Data.ConnectionState.Closed)
                    Connection.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"> Connection impossible.\n{ex.Message}");
                throw;
            }
        }
        public void NewConnection()
        {
            try
            {
                Connection = Dao.Connection.GetNewConnection();
                Command = Connection.CreateCommand();
                Adapter = DbProviderFactories.GetFactory("MySql.Data.MySqlClient").CreateDataAdapter();

                if (Connection.State == System.Data.ConnectionState.Closed)
                    Connection.Open();
            }
            catch (Exception)
            {
                MessageBox.Show("> Connection impossible.");
                throw;
            }
        }
    }

    public class DbUtil
    {
        public static DbParameter CreateParameter(DbCommand cmd, string paramName, DbType type, object value, ParameterDirection direction = ParameterDirection.Input)
        {
            var param = cmd.CreateParameter();
            param.ParameterName = paramName;
            param.DbType = type;
            param.Value = value;
            param.Direction = direction;

            return param;
        }
    }

    public class TableKeyHelper
    {
        public static string GetKey(string tableName, object add = null)
        {
            try
            {
                var key = string.Empty;

                key = AppConfig.CURRENT_USER?.Id ?? 1 + "" + tableName;

                key += Model.Helper.Util.GetMacAddress();
                key += Model.Helper.Util.GetClientIPAddress();
                key += Model.Helper.Util.GetClientMachineName();

                key += DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss:ffff");

                if (add != null)
                    key += (int)add;

                return Model.Helper.Util.MD5Hash(key);
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);
                return string.Empty;
            }
        }
    }
}