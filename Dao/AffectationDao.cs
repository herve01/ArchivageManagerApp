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
using System.ComponentModel;

namespace ArchiveManagerApp.Dao
{
    public class AffectationDao : Dao<Affectation>
    {
        public AffectationDao()
        {
            TableName = "affectation";
        }
        public override int Add(Affectation instance)
        {
            try
            {
                var id = TableKeyHelper.GetKey(TableName);

                Command.CommandText = "INSERT INTO affectation (id, agent_id, old_service_id, service_id, date, is_end) " +
                    "VALUES (@v_id, @v_agent_id, @v_old_service_id, @v_service_id, @v_date, @v_is_end) ";

                Command.Parameters.Add(DbUtil.CreateParameter(Command, "@v_id", System.Data.DbType.String, id));
                Command.Parameters.Add(DbUtil.CreateParameter(Command, "@v_agent_id", System.Data.DbType.String, instance.Agent.Id));
                Command.Parameters.Add(DbUtil.CreateParameter(Command, "@v_old_service_id", System.Data.DbType.String, instance?.OldService?.Id));
                Command.Parameters.Add(DbUtil.CreateParameter(Command, "@v_service_id", System.Data.DbType.String, instance.Service.Id));
                Command.Parameters.Add(DbUtil.CreateParameter(Command, "@v_date", System.Data.DbType.DateTime, instance.Date));
                Command.Parameters.Add(DbUtil.CreateParameter(Command, "@v_is_end", System.Data.DbType.Boolean, instance.IsEnd));

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

        public int Add(DbCommand command,  Affectation instance)
        {
            Command = command;
            Command.Parameters.Clear();

            return Add(instance);
        }

        public async Task<int> AddAsync(Affectation instance)
        {
            try
            {
                var id = TableKeyHelper.GetKey(TableName);

                Command.CommandText = "INSERT INTO affectation (id, agent_id, old_service_id, service_id, date, is_end) " +
                    "VALUES (@v_id, @v_agent_id, @v_old_service_id, @v_service_id, @v_date, @v_is_end) ";

                Command.Parameters.Add(DbUtil.CreateParameter(Command, "@v_id", System.Data.DbType.String, instance.Id));
                Command.Parameters.Add(DbUtil.CreateParameter(Command, "@v_agent_id", System.Data.DbType.String, instance.Agent.Id));
                Command.Parameters.Add(DbUtil.CreateParameter(Command, "@v_old_service_id", System.Data.DbType.String, instance.OldService.Id));
                Command.Parameters.Add(DbUtil.CreateParameter(Command, "@v_service_id", System.Data.DbType.String, instance.Service.Id));
                Command.Parameters.Add(DbUtil.CreateParameter(Command, "@v_date", System.Data.DbType.DateTime, instance.Date));
                Command.Parameters.Add(DbUtil.CreateParameter(Command, "@v_is_end", System.Data.DbType.Boolean, instance.IsEnd));

                var feed = await Command.ExecuteNonQueryAsync();

                if (feed > 0)
                    instance.Id = id;

                return 1;
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public async Task<int> AddAsync(DbCommand command, Affectation instance)
        {
            Command = command;
            Command.Parameters.Clear();

            return await AddAsync(instance);
        }

        public override int Delete(Affectation instance)
        {
            try
            {
                Command.CommandText = "DELETE FROM affectation WHERE id = @v_id";
                Command.Parameters.Add(DbUtil.CreateParameter(Command, "@v_id", System.Data.DbType.String, instance.Id));
                Command.ExecuteNonQuery();
                return 1;
            }
            catch (Exception)
            {
                return 0;
            }
        }
        public override int Update(Affectation instance)
        {
            try
            {
                Command.CommandText = "UPDATE affectation SET " +
                    "agent_id = @v_agent_id, " +
                    "old_service_id = @v_old_service_id, " +
                    "service_id = @v_service_id, " +
                    "date = @v_service_id, " +
                    "is_end = @v_is_end " +
                    "WHERE id = @v_id";

                Command.Parameters.Add(DbUtil.CreateParameter(Command, "@v_agent_id", System.Data.DbType.String, instance.Agent.Id));
                Command.Parameters.Add(DbUtil.CreateParameter(Command, "@v_old_service_id", System.Data.DbType.String, instance.OldService.Id));
                Command.Parameters.Add(DbUtil.CreateParameter(Command, "@v_service_id", System.Data.DbType.String, instance.Service.Id));
                Command.Parameters.Add(DbUtil.CreateParameter(Command, "@v_date", System.Data.DbType.DateTime, instance.Date));
                Command.Parameters.Add(DbUtil.CreateParameter(Command, "@v_is_end", System.Data.DbType.Boolean, instance.IsEnd));
                Command.Parameters.Add(DbUtil.CreateParameter(Command, "@v_id", System.Data.DbType.String, instance.Id));
                
                return 1;
            }
            catch (Exception)
            {
                return 0;
            }
        }
        public Affectation Get(string id)
        {
            try
            {
                Affectation instance = null;
                Dictionary<string, object> _instance = null;

                Command.CommandText = "SELECT * FROM affectation WHERE id = @v_id";

                Command.Parameters.Add(DbUtil.CreateParameter(Command, "@v_id", System.Data.DbType.String, id));


                Reader = Command.ExecuteReader();

                if (Reader != null && Reader.HasRows)
                    if (Reader.Read())
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

        public Affectation Get(Agent agent)
        {
            try
            {
                Affectation instance = null;
                Dictionary<string, object> _instance = null;

                Command.CommandText = "SELECT * FROM affectation WHERE agent_id = @v_agent_id " +
                    "order by date desc " +
                    "limit 1";

                Command.Parameters.Add(DbUtil.CreateParameter(Command, "@v_agent_id", System.Data.DbType.String, agent.Id));


                Reader = Command.ExecuteReader();

                if (Reader != null && Reader.HasRows)
                    if (Reader.Read())
                        _instance = GetMapping(Reader);

                Reader.Close();

                if (_instance != null)
                {
                    instance = Create(_instance, false, true, true);
                    instance.Agent = agent;
                }                   

                return instance;
            }
            catch (Exception)
            {

                return null;
            }
        }
        public async Task<List<Affectation>> GetAllAsync()
        {
            var instances = new List<Affectation>();
            var _instances = new List<Dictionary<string, object>>();

            try
            {
                Command.CommandText = "SELECT * FROM affectation";
                Reader = await Command.ExecuteReaderAsync();


                if (Reader != null & Reader.HasRows)
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
                { "agent_id", reader["agent_id"] },
                { "old_service_id", reader["old_service_id"] },
                { "service_id", reader["service_id"] },
                { "date", reader["date"] },
            };
        }
        Affectation Create(Dictionary<string, object> row, bool withAgent = false, bool withService = false, bool withOldService = false)
        {
            var instance = new Affectation();

            instance.Id = row["id"].ToString();
            instance.Date = DateTime.Parse(row["date"].ToString());

            if (withAgent)
                instance.Agent = new AgentDao().Get(row["agent_id"].ToString());

            if (withService)
                instance.Service = new ServiceDao().Get(row["service_id"].ToString());

            if (withOldService)
                instance.OldService = new ServiceDao().Get(row["old_service_id"].ToString());

            return instance;
        }
    }
       
}
