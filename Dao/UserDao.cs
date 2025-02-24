using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;
using ArchiveManagerApp.Model;
using NetFact_MVP.Dao.Util;
using RoadTripAgencyApp.Dao.Helper;

namespace ArchiveManagerApp.Dao
{
    public class UserDao : Dao<User>
    {
        public UserDao()
        {
            TableName = "user";
        }

        public override int Add(User instance)
        {
            try
            {
                var id = TableKeyHelper.GetKey(TableName);

                Command.CommandText = "INSERT INTO user (id, agent_id, login, passeword) " +
                    "VALUES (@v_id, @v_agent_id, @v_login, @v_passeword) ";

                Command.Parameters.Add(Parametres.CreateParameter(Command, "@v_id", System.Data.DbType.String, instance.Id));
                Command.Parameters.Add(Parametres.CreateParameter(Command, "@v_agent_id", System.Data.DbType.String, instance.Agent.Id));
                Command.Parameters.Add(Parametres.CreateParameter(Command, "@v_login", System.Data.DbType.String, instance.Login));
                Command.Parameters.Add(Parametres.CreateParameter(Command, "@v_passeword", System.Data.DbType.String, instance.Password));
        
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
        public override int Delete(User instance)
        {
            try
            {
                Command.CommandText = $"DELETE FROM Annonce WHERE id = @v_id";

                Command.Parameters.Add(Parametres.CreateParameter(Command, "@v_id", System.Data.DbType.String, instance.Id));

                Command.ExecuteNonQuery();

                return 1;
            }
            catch (Exception)
            {
                return 0;
            }
        }
        public override int Update(User instance)
        {
            try
            {
                Command.CommandText = $"UPDATE Message SET passeword=@v_description, photo=@v_images WHERE Id=@v_id";

                Command.Parameters.Add(Parametres.CreateParameter(Command, "@v_id", System.Data.DbType.String, instance.Id));
                Command.Parameters.Add(Parametres.CreateParameter(Command, "@v_agent_id", System.Data.DbType.String, instance.Agent.Id));
                Command.Parameters.Add(Parametres.CreateParameter(Command, "@v_login", System.Data.DbType.String, instance.Login));
                Command.Parameters.Add(Parametres.CreateParameter(Command, "@v_passeword", System.Data.DbType.String, instance.Password));
                
                Command.ExecuteNonQuery();

                return 1;
            }
            catch (Exception)
            {
                return 0;
            }
        }
        public User Get(string id)
        {
            User instance = null;
            Dictionary<string, object> _instance = null;

            try
            {
                Command.CommandText = $"SELECT * FROM user WHERE id=@v_id";

                Command.Parameters.Add(Parametres.CreateParameter(Command, "@v_id", System.Data.DbType.String, id));

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
        public async Task<List<User>> GetAllAsync()
        {
            List<User> instances = new List<User>();
            List<Dictionary<string, object>> _instances = new List<Dictionary<string, object>>();

            try
            {
                Command.CommandText = "SELECT * FROM annonce";

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
                { "agent_id", reader["agent_id"] },
                { "login", reader["login"] },
                { "passeword", reader["passeword"] },
                { "photo", reader["photo"] },
                { "date_publication", reader["date_publication"] }
            };
        }
        User Create(Dictionary<string, object> row, bool withagent_id = false)
        {
            var instance = new User();

            instance.Id = row["id"].ToString();
            
            //instance.login = row["login"].ToString();
            //instance.Description = row["passeword"].ToString();
            //instance.DatePublication = DateTime.Parse(row["date_publication"].ToString());

            //if (withagent_id)
            //    instance.agent_id = new AgentDao().Get(row["agent_id"].ToString());


            return instance;
        }
    }

}
