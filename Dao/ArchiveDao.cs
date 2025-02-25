using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;
using ArchiveManagerApp.Model;
using ArchiveManagerApp.Dao.Util;
using RoadTripAgencyApp.Dao.Helper;

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
                var id = TableKeyHelper.GetKey(TableName);

                Command.CommandText = "INSERT INTO Archive (id, document_id, user_id, date_archivage) VALUES (@id, @document_id, @user_id, @date_archivage)";

                Command.Parameters.Add(DbUtil.CreateParameter(Command, "@id", System.Data.DbType.String, id));
                Command.Parameters.Add(DbUtil.CreateParameter(Command, "@document_id", System.Data.DbType.String, instance.Document.Id));
                Command.Parameters.Add(DbUtil.CreateParameter(Command, "@user_id", System.Data.DbType.String, instance.User.Id));
                Command.Parameters.Add(DbUtil.CreateParameter(Command, "@user_id", System.Data.DbType.String, instance.User.Id));
                Command.Parameters.Add(DbUtil.CreateParameter(Command, "@date_archivage", System.Data.DbType.String, instance.Date_Archivage));
                
                var feed = Command.ExecuteNonQuery();

                if (feed > 0)
                    instance.Id = id;

                return 1;
            }
            catch (Exception)
            {
                return 0;
            }
        }
        public override int Delete(Archive instance)
        {
            try
            {
                Command.CommandText = $"DELETE FROM Archive WHERE Id={instance.Id}";
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
                Command.CommandText = $"UPDATE Archive SET document_id=@document_id, user_id=@user_id, date_archivage=@date_archivage WHERE Id=@id";

                Command.Parameters.Add(DbUtil.CreateParameter(Command, "@id", System.Data.DbType.String, "id"));
                Command.Parameters.Add(DbUtil.CreateParameter(Command, "@document_id", System.Data.DbType.String, instance.Document.Id));
                Command.Parameters.Add(DbUtil.CreateParameter(Command, "@user_id", System.Data.DbType.String, instance.User.Id));
                Command.Parameters.Add(DbUtil.CreateParameter(Command, "@user_id", System.Data.DbType.String, instance.User.Id));
                Command.Parameters.Add(DbUtil.CreateParameter(Command, "@date_archivage", System.Data.DbType.String, instance.Date_Archivage));
                Command.ExecuteNonQuery();

                return 1;
            }
            catch (Exception)
            {
                return 0;
            }
        }
        public async Task<Archive> GetAsync(string id)
        {
            Archive instance = null;
            Dictionary<string, object> _instance = null;

            try
            {
                ;
                Command.CommandText = $"SELECT * FROM Archive WHERE id=@id";

                Command.Parameters.Add(DbUtil.CreateParameter(Command, "@id", System.Data.DbType.String, id));

                Reader = await Command.ExecuteReaderAsync();

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
        public Archive Get(string id)
        {
            Archive instance = null;
            Dictionary<string, object> _instance = null;

            try
            {
               
                Command.CommandText = $"SELECT * FROM Archive WHERE id=@id";


                Command.Parameters.Add(DbUtil.CreateParameter(Command, "@id", System.Data.DbType.String, id));

                Reader = Command.ExecuteReader();

                if (Reader != null && Reader.HasRows)
                    if(Reader.Read())
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
            List<Archive> instances = new List<Archive>();
            List<Dictionary<string, object>> _instances = new List<Dictionary<string, object>>();

            try
            {
                Command.CommandText = "SELECT * FROM Archive";

                Reader = await Command.ExecuteReaderAsync();

                if (Reader.HasRows)
                    while (Reader.Read())
                    {
                        _instances.Add(GetMapping(Reader));
                    }

                Reader.Close();

                foreach (var row in _instances)
                {
                    instances.Add(Create(row));
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
                { "date_archivage", reader["date_archivage"] },
            };
        }
        Archive Create(Dictionary<string, object> row)
        {
            var instance = new Archive();

            instance.Id = row["id"].ToString();
            //instance.Document = row["nom"].ToString();
            //instance.User = row["postnom"].ToString();
            instance.Date_Archivage = DateTime.Parse(row["date_archivage"].ToString());

            return instance;
        }
    }
}
