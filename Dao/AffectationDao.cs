using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;
using ArchiveManagerApp.Model;
using NetFact_MVP.Dao.Util;

namespace ArchiveManagerApp.Dao
{
    public class AffectationDao : Dao<Affectation>
    {
        public override int Add(Affectation instance)
        {
            try
            {
                Command.CommandText = "INSERT INTO Affectattion (id, agent_id, service_id) VALUES (@id, @agent_id, @service_id) ";

                Command.Parameters.Add(Parametres.CreateParameter(Command, "@id", System.Data.DbType.String, instance.Id));
                Command.Parameters.Add(Parametres.CreateParameter(Command, "@agent_id", System.Data.DbType.String, instance.Agent.Id));
                Command.Parameters.Add(Parametres.CreateParameter(Command, "@service_id", System.Data.DbType.String, instance.Service.Id));
                Command.ExecuteNonQuery();

                return 1;
            }
            catch (Exception)
            {
                return 0;
            }
        }
        public override int Delete(Affectation instance)
        {
            try
            {
                Command.CommandText = $"DELETE FROM Affectation WHERE Id={instance.Id}";
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
                Command.CommandText = $"UPDATE Affectation SET agent_id=@agent_id, service_id=@service_id WHERE Id=@id";

                Command.Parameters.Add(Parametres.CreateParameter(Command, "@id", System.Data.DbType.String, instance.Id));
                Command.Parameters.Add(Parametres.CreateParameter(Command, "@agent_id", System.Data.DbType.String, instance.Agent.Id));
                Command.Parameters.Add(Parametres.CreateParameter(Command, "@service_id", System.Data.DbType.String, instance.Service.Id));
                Command.ExecuteNonQuery();

                return 1;
            }
            catch (Exception)
            {
                return 0;
            }
        }
        public  async Task<Affectation> Get(string id)
        {
            try
            {
                Affectation affectation = new Affectation();
                Command.CommandText = $"SELECT * FROM Affectation WHERE Id={@id}";

                Reader = await Command.ExecuteReaderAsync();

                if (Reader != null && Reader.HasRows)
                {
                    affectation.Id = id;
                    affectation.Agent =  new AgentDao().Get(Reader["expediteur"].ToString());
                    affectation.Service =  new ServiceDao().Get(Reader["destinateur"].ToString());
                }

                Reader.Close();
                return affectation;
            }
            catch (Exception)
            {

                return null;
            }
        }
        public async Task<List<Affectation>> GetAllAsync()
        {
            List<Affectation> liste_Affectations = new List<Affectation>();

            try
            {
                Command.CommandText = $"SELECT * FROM Affectation";
                Reader = await Command.ExecuteReaderAsync();

                while (Reader.Read())
                {

                    if (Reader != null & Reader.HasRows)
                    {
                        Affectation nouveau_Affectation = new Affectation();
                        //nouveau_Affectation.Id = Reader["id"].ToString();
                        //nouveau_Affectation.Expediteur = await new UserDao().Get(Reader["expediteur"].ToString());
                        //nouveau_Affectation.Destinateur =await new UserDao().Get(Reader["destinateur"].ToString());
                        //nouveau_Affectation.Description = Reader["description"].ToString();
                        //nouveau_Affectation.DateEnvoie = Convert.ToDateTime(Reader["date_envoie"].ToString());

                        liste_Affectations.Add(nouveau_Affectation);
                    }
                }

                Reader.Close();
                return liste_Affectations;
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
