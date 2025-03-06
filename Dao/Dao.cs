using System;
using System.Collections.Generic;
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
}
