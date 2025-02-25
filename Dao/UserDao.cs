using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using ArchiveManagerApp.Model;
using RoadTripAgencyApp.Dao.Helper;
using System.Data.Common;
using ArchiveManagerApp.Dao.Util;

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

                var hash = PasswordStorage.CreateHash(instance.PassWd);
                var split = hash.Split(':');
                var salt = split[0];
                var pwd = string.Format("{0}:{1}", split[1], split[2]);

                Command.CommandText = "INSERT INTO user (id, agent_id, username, passwd, salt) " +
                    "VALUES (@v_id, @v_agent_id, @v_username, @v_passwd, @v_salt) ";

                Command.Parameters.Add(DbUtil.CreateParameter(Command, "@v_id", DbType.String, instance.Id));
                Command.Parameters.Add(DbUtil.CreateParameter(Command, "@v_agent_id", DbType.String, instance.Agent.Id));
                Command.Parameters.Add(DbUtil.CreateParameter(Command, "@v_login", DbType.String, instance.UserName));
                Command.Parameters.Add(DbUtil.CreateParameter(Command, "@v_passwd", DbType.String, pwd));
                Command.Parameters.Add(DbUtil.CreateParameter(Command, "@v_salt", DbType.String, salt));

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
                Command.CommandText = $"DELETE FROM user WHERE id = @v_id";

                Command.Parameters.Add(DbUtil.CreateParameter(Command, "@v_id", DbType.String, instance.Id));

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
                Command.CommandText = $"UPDATE user " +
                    "SET agent_id = @v_agent_id, " +
                    "username = @v_username" +
                    "WHERE id = @v_id";

                Command.Parameters.Add(DbUtil.CreateParameter(Command, "@v_id", DbType.String, instance.Id));
                Command.Parameters.Add(DbUtil.CreateParameter(Command, "@v_agent_id", DbType.String, instance.Agent.Id));
                Command.Parameters.Add(DbUtil.CreateParameter(Command, "@v_username", DbType.String, instance.UserName));
                
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

                Command.Parameters.Add(DbUtil.CreateParameter(Command, "@v_id", DbType.String, id));

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

        public User Get(string username, string passwd)
        {
            User user = null;
            Dictionary<string, object> _user = null;

            try
            {
                Command.CommandText = "select * " +
                    "from user " +
                    "where username = @v_username or email = @v_username";

                Command.Parameters.Add(DbUtil.CreateParameter(Command, "@v_username", DbType.String, username));

                Reader = Command.ExecuteReader();

                if (Reader.HasRows && Reader.Read())
                {
                    var uPwd = Reader["passwd"].ToString();
                    var uSalt = Reader["m_salt"].ToString();

                    if (PasswordStorage.VerifyPassword(passwd, uSalt, uPwd))
                        _user = GetMapping(Reader);
                }

                Reader.Close();

                if (_user != null)
                    user = Create(_user);
            }
            catch (Exception)
            {
            }

            return user;
        }
        public async Task<List<User>> GetAllAsync()
        {
            var instances = new List<User>();
            var _instances = new List<Dictionary<string, object>>();

            try
            {
                Command.CommandText = "SELECT * FROM user";

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
                { "username", reader["username"] },
            };
        }
        User Create(Dictionary<string, object> row, bool withAgent = true)
        {
            var instance = new User();

            instance.Id = row["id"].ToString();
            instance.UserName = row["username"].ToString();

            if (withAgent)
                instance.Agent = new AgentDao().Get(row["agent_id"].ToString());

            return instance;
        }
    }

}
