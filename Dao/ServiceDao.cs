using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Threading.Tasks;
using ArchiveManagerApp.Model;
using ArchiveManagerApp.Dao.Util;
using RoadTripAgencyApp.Dao.Helper;

namespace ArchiveManagerApp.Dao
{
    public class ServiceDao : Dao<Service>
    {
        public ServiceDao()
        {
            TableName = "service";
        }
        public override int Add(Service instance)
        {
            try
            {
                var id = TableKeyHelper.GetKey(TableName);

                Command.CommandText = "INSERT INTO service (id, designation) VALUES (@v_id, @v_designation)";

                Command.Parameters.Add(DbUtil.CreateParameter(Command, "@v_id", System.Data.DbType.String, id));
                Command.Parameters.Add(DbUtil.CreateParameter(Command, "@v_designation", System.Data.DbType.String, instance.Designation));
                
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
        public override int Delete(Service instance)
        {
            try
            {
                Command.CommandText = $"DELETE FROM service WHERE id = @v_id";
                Command.Parameters.Add(DbUtil.CreateParameter(Command, "@v_id", System.Data.DbType.String, instance.Id));
                Command.ExecuteNonQuery();

                return 1;
            }
            catch (Exception)
            {
                return 0;
            }
        }
        public override int Update(Service instance)
        {
            try
            {
                Command.CommandText = $"UPDATE Service " +
                    $"SET designation = @v_designation " +
                    $"WHERE Id = @v_id";

                Command.Parameters.Add(DbUtil.CreateParameter(Command, "@v_id", System.Data.DbType.String, instance.Id));
                Command.Parameters.Add(DbUtil.CreateParameter(Command, "@v_designation", System.Data.DbType.String, instance.Designation));
                Command.ExecuteNonQuery();

                return 1;
            }
            catch (Exception)
            {
                return 0;
            }
        }
        public Service Get(string id)
        {
            Service instance = null;
            Dictionary<string, object> _instance = null;

            try
            {
                Command.CommandText = $"SELECT * FROM service WHERE id = @v_id";

                Command.Parameters.Add(DbUtil.CreateParameter(Command, "@v_id", System.Data.DbType.String, id));

                Reader = Command.ExecuteReader();

                if (Reader != null && Reader.HasRows)
                    if(Reader.Read())
                        _instance = GetMapping(Reader);

                Reader.Close();

                if (_instance != null)
                    instance = Create(_instance, true);

                return instance;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public async Task<List<Service>> GetAllAsync()
        {
            var instances = new List<Service>();
            var _instances = new List<Dictionary<string, object>>();

            try
            {
                Command.CommandText = "SELECT * FROM service";

                Reader = await Command.ExecuteReaderAsync();

                if (Reader.HasRows)
                    while ( Reader.Read())
                    {
                        _instances.Add(GetMapping(Reader));
                    }

                Reader.Close();

                foreach (var row in _instances)
                {
                    instances.Add(Create(row, true));
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
                { "designation", reader["designation"] }
            };
        }
        Service Create(Dictionary<string, object> row, bool withAgents = false)
        {
            var instance = new Service();

            instance.Id = row["id"].ToString();          
            instance.Designation = row["designation"].ToString();

            if (withAgents) ;

            return instance;
        }
    }
}
