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

                Command.CommandText = "INSERT INTO affectation (id, agent_id, old_service_id, service_id, date) " +
                    "VALUES (@v_id, @v_agent_id, @v_old_service_id, @v_service_id, @v_date) ";

                Command.Parameters.Add(DbUtil.CreateParameter(Command, "@v_id", System.Data.DbType.String, instance.Id));
                Command.Parameters.Add(DbUtil.CreateParameter(Command, "@v_agent_id", System.Data.DbType.String, instance.Agent.Id));
                Command.Parameters.Add(DbUtil.CreateParameter(Command, "@v_old_service_id", System.Data.DbType.String, instance.OldService.Id));
                Command.Parameters.Add(DbUtil.CreateParameter(Command, "@v_service_id", System.Data.DbType.String, instance.Service.Id));
                Command.Parameters.Add(DbUtil.CreateParameter(Command, "@v_date", System.Data.DbType.DateTime, instance.Date));

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

                Command.CommandText = "INSERT INTO affectation (id, agent_id, old_service_id, service_id, date) " +
                    "VALUES (@v_id, @v_agent_id, @v_old_service_id, @v_service_id, @v_date) ";

                Command.Parameters.Add(DbUtil.CreateParameter(Command, "@v_id", System.Data.DbType.String, instance.Id));
                Command.Parameters.Add(DbUtil.CreateParameter(Command, "@v_agent_id", System.Data.DbType.String, instance.Agent.Id));
                Command.Parameters.Add(DbUtil.CreateParameter(Command, "@v_old_service_id", System.Data.DbType.String, instance.OldService.Id));
                Command.Parameters.Add(DbUtil.CreateParameter(Command, "@v_service_id", System.Data.DbType.String, instance.Service.Id));
                Command.Parameters.Add(DbUtil.CreateParameter(Command, "@v_date", System.Data.DbType.DateTime, instance.Date));

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

        public int Add(DbCommand command, Affectation instance)
        {
            Command = command;
            Command.Parameters.Clear();

            return Add(instance);
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
                Command.CommandText = $"UPDATE affectation SET agent_id=@agent_id, service_id=@service_id WHERE Id=@id";

                Command.Parameters.Add(DbUtil.CreateParameter(Command, "@id", System.Data.DbType.String, instance.Id));
                Command.Parameters.Add(DbUtil.CreateParameter(Command, "@agent_id", System.Data.DbType.String, instance.Agent.Id));
                Command.Parameters.Add(DbUtil.CreateParameter(Command, "@service_id", System.Data.DbType.String, instance.Service.Id));
                Command.ExecuteNonQuery();

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

                Command.CommandText = "SELECT * FROM affectation WHERE id=@v_id";

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
        public async Task<List<Affectation>> GetAllAsync()
        {
            List<Affectation> liste_affectations = new List<Affectation>();

            try
            {
                Command.CommandText = $"SELECT * FROM affectation";
                Reader = await Command.ExecuteReaderAsync();

                while (Reader.Read())
                {

                    if (Reader != null & Reader.HasRows)
                    {
                        affectation nouveau_affectation = new affectation();
                        //nouveau_affectation.Id = Reader["id"].ToString();
                        //nouveau_affectation.Expediteur = await new UserDao().Get(Reader["expediteur"].ToString());
                        //nouveau_affectation.Destinateur =await new UserDao().Get(Reader["destinateur"].ToString());
                        //nouveau_affectation.Description = Reader["description"].ToString();
                        //nouveau_affectation.DateEnvoie = Convert.ToDateTime(Reader["date_envoie"].ToString());

                        liste_affectations.Add(nouveau_affectation);
                    }
                }

                Reader.Close();
                return liste_affectations;
            }
            catch (Exception)
            {
                return null;
            }
        }

        protected override Dictionary<string, object> GetMapping(DbDataReader reader)
        {
            throw new NotImplementedException();
        }
    }
       
}
