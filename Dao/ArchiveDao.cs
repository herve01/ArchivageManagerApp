using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;
using ArchiveManagerApp.Model;
using ArchiveManagerApp.Dao.Util;
using ArchiveManagerApp.Dao.Helper;

namespace ArchiveManagerApp.Dao
{
    public class ArchiveDao : Dao<Archive>
    {
        public ArchiveDao()
        {
            TableName = "archive";
        }
        public override int Add(Archive instance)
        {
            try
            {
                Command.Transaction = Connection.BeginTransaction();


                if (new DocumentDao().Add(Command, instance.Document) <= 0)
                {
                    instance.Id = null;

                    Command.Transaction.Rollback();
                    return -1;
                }

                var id = TableKeyHelper.GetKey(TableName);

                Command.CommandText = "INSERT INTO archive (id, user_id, document_id, date) " +
                    "VALUES (@v_id, @v_user_id, @v_document_id, @v_date)";

                Command.Parameters.Add(DbUtil.CreateParameter(Command, "@v_id", System.Data.DbType.String, id));
                Command.Parameters.Add(DbUtil.CreateParameter(Command, "@v_user_id", System.Data.DbType.String, instance.Document.Id));
                Command.Parameters.Add(DbUtil.CreateParameter(Command, "@v_document_id", System.Data.DbType.String, instance.User.Id));
                Command.Parameters.Add(DbUtil.CreateParameter(Command, "@v_date", System.Data.DbType.DateTime, instance.User.Id));
                
                var feed = Command.ExecuteNonQuery();
                instance.Id = id;

                if (feed < 0)
                {
                    instance.Id = null;
                    Command.Transaction.Rollback();
                    return -2;
                }

                Command.Transaction.Commit();

                return feed;
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(TableName + " " + e.Message);
                if (Command.Transaction != null)
                    Command.Transaction.Rollback();
                return -1;
            }
        }
        public override int Delete(Archive instance)
        {
            try
            {
                Command.CommandText = "DELETE FROM Archive WHERE id = @v_id";

                Command.Parameters.Add(DbUtil.CreateParameter(Command, "@v_id", System.Data.DbType.String, instance.Id));

                Command.ExecuteNonQuery();

                return 1;
            }
            catch (Exception)
            {
                return 0;
            }

        }
        public override int Update(Archive instance)
        {
            try
            {
                Command.CommandText = "UPDATE Archive SET " +
                    "user_id = @v_user_id, " +
                    "document_id = @v_document_id, " +
                    "date = @v_date" +
                    "WHERE id = @v_id";

                Command.Parameters.Add(DbUtil.CreateParameter(Command, "@v_user_id", System.Data.DbType.String, instance.Document.Id));
                Command.Parameters.Add(DbUtil.CreateParameter(Command, "@v_document_id", System.Data.DbType.String, instance.User.Id));
                Command.Parameters.Add(DbUtil.CreateParameter(Command, "@v_date", System.Data.DbType.DateTime, instance.User.Id));
                Command.Parameters.Add(DbUtil.CreateParameter(Command, "@v_id", System.Data.DbType.String, instance.Id));

                Command.ExecuteNonQuery();

                return 1;
            }
            catch (Exception)
            {
                return 0;
            }
        }
        public Archive Get(string id)
        {
            Archive instance = null;
            Dictionary<string, object> _instance = null;

            try
            {
                Command.CommandText = "SELECT * FROM archive WHERE id = @v_id";

                Command.Parameters.Add(DbUtil.CreateParameter(Command, "@v_id", System.Data.DbType.String, id));

                Reader = Command.ExecuteReader();

                if (Reader != null && Reader.HasRows)
                    _instance = GetMapping(Reader);

                Reader.Close();

                if (_instance != null)
                    instance = Create(_instance);

                return instance;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public async Task<List<Archive>> GetAllAsync()
        {
            var instances = new List<Archive>();
            var _instances = new List<Dictionary<string, object>>();

            try
            {
                Command.CommandText = "SELECT * FROM archive order by date asc";

                Reader = await Command.ExecuteReaderAsync();

                if (Reader.HasRows)
                    while (Reader.Read())
                    {
                        _instances.Add(GetMapping(Reader));
                    }

                Reader.Close();

                foreach (var row in _instances)
                {
                    instances.Add(Create(row, true, true));
                }

                return instances;
            }
            catch (Exception)
            {
                return null;
            }
        }
        protected override Dictionary<string, object> GetMapping(DbDataReader reader)
        {
            return new Dictionary<string, object>()
            {
                { "id", reader["id"] },
                { "document_id", reader["document_id"] },
                { "user_id", reader["user_id"] },
                { "date", reader["date"] },
            };
        }
        Archive Create(Dictionary<string, object> row, bool withUser = false, bool withDoc = false)
        {
            var instance = new Archive();

            instance.Id = row["id"].ToString();
            instance.Date = DateTime.Parse(row["date"].ToString());

            if (withUser)
                instance.User = new UserDao().Get(row["user_id"].ToString());

            if (withDoc)
                instance.Document = new DocumentDao().Get(row["document_id"].ToString());

            return instance;
        }
    }
}
