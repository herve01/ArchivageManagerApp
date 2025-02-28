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
    public class AgentDao : Dao<Agent>
    {
        public AgentDao()
        {
            TableName = "agent";
        }
        public override int Add(Agent instance)
        {
            try
            {
                Command.Transaction = Connection.BeginTransaction();

                var id = TableKeyHelper.GetKey(TableName);

                Command.CommandText = "INSERT INTO agent (id, nom, postnom, prenom, sexe, telephone, photo, fonction, grade) " +
                                      "VALUES (@v_id, @v_nom, @v_postnom, @v_prenom, @v_sexe, @v_telephone, @v_photo, @v_fonction, @v_grade)";

                Command.Parameters.Add(DbUtil.CreateParameter(Command, "@v_id", System.Data.DbType.String, id));
                Command.Parameters.Add(DbUtil.CreateParameter(Command, "@v_nom", System.Data.DbType.String, instance.Nom));
                Command.Parameters.Add(DbUtil.CreateParameter(Command, "@v_postnom", System.Data.DbType.String, instance.PostNom));
                Command.Parameters.Add(DbUtil.CreateParameter(Command, "@v_prenom", System.Data.DbType.String, instance.Prenom));
                Command.Parameters.Add(DbUtil.CreateParameter(Command, "@v_sexe", System.Data.DbType.String, instance.Sexe));
                Command.Parameters.Add(DbUtil.CreateParameter(Command, "@v_telephone", System.Data.DbType.String, instance.Phone));
                Command.Parameters.Add(DbUtil.CreateParameter(Command, "@v_mail", System.Data.DbType.String, instance.Email));
                Command.Parameters.Add(DbUtil.CreateParameter(Command, "@v_photo", System.Data.DbType.Binary, instance.Photo));
                Command.Parameters.Add(DbUtil.CreateParameter(Command, "@v_fonction", System.Data.DbType.String, instance.Fonction));
                Command.Parameters.Add(DbUtil.CreateParameter(Command, "@v_grade", System.Data.DbType.String, instance.Grade));
                
                var feed = Command.ExecuteNonQuery();
                instance.Id = id;

                if (feed < 0)
                {
                    instance.Id = null;
                    Command.Transaction.Rollback();
                    return -1;
                }

                if (new AffectationDao().Add(Command, instance.CurrentAffectation) <= 0)
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
        public override int Delete(Agent instance)
        {
            try
            {
                Command.CommandText = "DELETE FROM agent WHERE id = @v_id";
                Command.Parameters.Add(DbUtil.CreateParameter(Command, "@v_id", System.Data.DbType.String, instance.Id));
                Command.ExecuteNonQuery();
                return 1;
            }
            catch (Exception)
            {
                return 0;
            }

        }
        public override int Update(Agent instance)
        {
            try
            {
                Command.CommandText = "UPDATE Agent " +
                                       "SET nom = @v_nom, " +
                                       "postnom = @v_postnom, " +
                                       "prenom = @v_prenom, " +
                                       "sexe = @v_sexe, " +
                                       "telephone = @v_telephone, " +
                                       "mail = @v_mail, " +
                                       "photo = @v_photo, " +
                                      "fonction = @v_fonction," +
                                      "grade = @v_grade " +
                                      "WHERE id = @v_id";

                Command.Parameters.Add(DbUtil.CreateParameter(Command, "@v_nom", System.Data.DbType.String, instance.Nom));
                Command.Parameters.Add(DbUtil.CreateParameter(Command, "@v_postnom", System.Data.DbType.String, instance.PostNom));
                Command.Parameters.Add(DbUtil.CreateParameter(Command, "@v_prenom", System.Data.DbType.String, instance.Prenom));
                Command.Parameters.Add(DbUtil.CreateParameter(Command, "@v_sexe", System.Data.DbType.String, instance.Sexe));
                Command.Parameters.Add(DbUtil.CreateParameter(Command, "@v_telephone", System.Data.DbType.String, instance.Phone));
                Command.Parameters.Add(DbUtil.CreateParameter(Command, "@v_mail", System.Data.DbType.String, instance.Email));
                Command.Parameters.Add(DbUtil.CreateParameter(Command, "@v_photo", System.Data.DbType.Binary, instance.Photo));
                Command.Parameters.Add(DbUtil.CreateParameter(Command, "@v_fonction", System.Data.DbType.String, instance.Fonction));
                Command.Parameters.Add(DbUtil.CreateParameter(Command, "@v_grade", System.Data.DbType.String, instance.Grade));
                Command.Parameters.Add(DbUtil.CreateParameter(Command, "@v_id", System.Data.DbType.String, instance.Id));
                
                Command.ExecuteNonQuery();

                return 1;
            }
            catch (Exception)
            {
                return 0;
            }
        }
        public Agent Get(string id)
        {
            Agent instance = null;
            Dictionary<string, object> _instance = null;

            try
            {              
                Command.CommandText = "SELECT * FROM agent WHERE id = @v_id";

                Command.Parameters.Add(DbUtil.CreateParameter(Command, "@v_id", System.Data.DbType.String, id));

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
        public async Task<List<Agent>> GetAllAsync()
        {
            var instances = new List<Agent>();
            var _instances = new List<Dictionary<string, object>>();

            try
            {
                Command.CommandText = "SELECT * FROM agent";

                Reader = await Command.ExecuteReaderAsync();

                if (Reader.HasRows)
                    while (Reader.Read())
                    {
                        _instances.Add(GetMapping(Reader));
                    }

                Reader.Close();
                int i = 0;
                foreach (var row in _instances)
                {
                    i++;
                    var _obj = Create(row, true); 
                    _obj.NumberRow = i;
                    instances.Add(_obj);
                }

                return instances;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public List<Agent> GetAll(Service service)
        {
            var instances = new List<Agent>();
            var _instances = new List<Dictionary<string, object>>();

            try
            {
                Command.CommandText = "SELECT Ag.* FROM agent Ag " +
                    "INNER JOIN " +
                    "(select * FROM affectation where is_end = 1) A " +
                    "ON Ag.id = A.agent_id " +
                    "WHERE A.service_id = @v_service_id";

                Command.Parameters.Add(DbUtil.CreateParameter(Command, "@v_service_id", System.Data.DbType.String, service.Id));

                Reader = Command.ExecuteReader();

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
                { "nom", reader["nom"] },
                { "postnom", reader["prenom"] },
                { "prenom", reader["prenom"] },
                { "sexe", reader["sexe"] },
                { "telephone", reader["telephone"] },
                { "mail", reader["mail"] },
                { "fonction", reader["fonction"] },
                { "grade", reader["grade"] },
            };
        }
        Agent Create(Dictionary<string, object> row, bool withCurrentAffec = false)
        {
            var instance = new Agent();

            instance.Id = row["id"].ToString();
            instance.Nom = row["nom"].ToString();
            instance.PostNom = row["postnom"].ToString();
            instance.Prenom = row["prenom"].ToString();
            instance.Sexe = row["sexe"].ToString();
            instance.Phone = row["telephone"].ToString();
            instance.Email = row["mail"].ToString();
            instance.Fonction = row["fonction"].ToString();
            instance.Grade = row["grade"].ToString();

            if (withCurrentAffec)
                instance.CurrentAffectation = new AffectationDao().Get(instance);

            if (!(row["photo"] is DBNull))
                instance.Photo = (byte[])row["photo"];
            //instance.Photo = Convert.FromBase64String(row["photo"].ToString());

            return instance;
        }
    }
}
