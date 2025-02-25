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
using static RoadTripAgencyApp.Model.Helper.Util;

namespace ArchiveManagerApp.Dao
{
    public class DocumentDao : Dao<Document>
    {
        public DocumentDao()
        {
            TableName = "document";
        }
        public override int Add(Document instance)
        {
            try
            {
                var id = TableKeyHelper.GetKey(TableName);

                Command.CommandText = "INSERT INTO document (id, libelle, extension, mot_cle, fichier) " +
                    "VALUES (@v_id, @v_libelle, @v_extension, @v_mot_cle, @v_fichier) ";

                Command.Parameters.Add(DbUtil.CreateParameter(Command, "@v_id", System.Data.DbType.String, id));
                Command.Parameters.Add(DbUtil.CreateParameter(Command, "@v_libelle", System.Data.DbType.String, instance.Libelle));
                Command.Parameters.Add(DbUtil.CreateParameter(Command, "@v_extension", System.Data.DbType.String, instance.Extension));
                Command.Parameters.Add(DbUtil.CreateParameter(Command, "@v_mot_cle", System.Data.DbType.String, instance.MotCle));
                Command.Parameters.Add(DbUtil.CreateParameter(Command, "@v_fichier", System.Data.DbType.Binary, instance.Fichier));

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

        public int Add(DbCommand command, Document instance)
        {
            Command = command;
            Command.Parameters.Clear();

            return Add(instance);
        }

        public async Task<int> AddAsync(Document instance)
        {
            try
            {
                var id = TableKeyHelper.GetKey(TableName);

                Command.CommandText = "INSERT INTO document (id, libelle, extension, mot_cle, fichier) " +
                    "VALUES (@v_id, @v_libelle, @v_extension, @v_mot_cle, @v_fichier) ";

                Command.Parameters.Add(DbUtil.CreateParameter(Command, "@v_id", System.Data.DbType.String, id));
                Command.Parameters.Add(DbUtil.CreateParameter(Command, "@v_libelle", System.Data.DbType.String, instance.Libelle));
                Command.Parameters.Add(DbUtil.CreateParameter(Command, "@v_extension", System.Data.DbType.String, instance.Extension));
                Command.Parameters.Add(DbUtil.CreateParameter(Command, "@v_mot_cle", System.Data.DbType.String, instance.MotCle));
                Command.Parameters.Add(DbUtil.CreateParameter(Command, "@v_fichier", System.Data.DbType.Binary, instance.Fichier));

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

        public async Task<int> AddAsync(DbCommand command, Document instance)
        {
            Command = command;
            Command.Parameters.Clear();

            return await AddAsync(instance);
        }

        public override int Delete(Document instance)
        {
            try
            {
                Command.CommandText = $"DELETE FROM Annonce WHERE id = @v_id";

                Command.Parameters.Add(DbUtil.CreateParameter(Command, "@v_id", System.Data.DbType.String, instance.Id));

                Command.ExecuteNonQuery();

                return 1;
            }
            catch (Exception)
            {
                return 0;
            }
        }
        public override int Update(Document instance)
        {
            try
            {
                Command.CommandText = $"UPDATE document SET " +
                    "libelle = @v_libelle, " +
                    "extension = @v_extension, " +
                    "mot_cle = @v_mot_cle, " +
                    "fichier = @v_fichier " +
                    "WHERE id = @v_id";

                Command.Parameters.Add(DbUtil.CreateParameter(Command, "@v_libelle", System.Data.DbType.String, instance.Libelle));
                Command.Parameters.Add(DbUtil.CreateParameter(Command, "@v_extension", System.Data.DbType.String, instance.Extension));
                Command.Parameters.Add(DbUtil.CreateParameter(Command, "@v_mot_cle", System.Data.DbType.String, instance.MotCle));
                Command.Parameters.Add(DbUtil.CreateParameter(Command, "@v_fichier", System.Data.DbType.Binary, instance.Fichier));
                Command.Parameters.Add(DbUtil.CreateParameter(Command, "@v_id", System.Data.DbType.String, instance.Id));

                Command.ExecuteNonQuery();

                return 1;
            }
            catch (Exception)
            {
                return 0;
            }
        }
        public Document Get(string id)
        {
            Document instance = null;
            Dictionary<string, object> _instance = null;

            try
            {
                Command.CommandText = "SELECT * FROM document WHERE id = @v_id";

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
        public async Task<List<Document>> GetAllAsync()
        {
            List<Document> instances = new List<Document>();
            List<Dictionary<string, object>> _instances = new List<Dictionary<string, object>>();

            try
            {
                Command.CommandText = "SELECT * FROM document";

                Reader = await Command.ExecuteReaderAsync();

                if (Reader.HasRows)
                    while ( Reader.Read())
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
                { "libelle", reader["libelle"] },
                { "extension", reader["extension"] },
                { "mot_cle", reader["mot_cle"] },
                { "fichier", reader["fichier"] }
            };
        }
        Document Create(Dictionary<string, object> row)
        {
            var instance = new Document();

            instance.Id = row["id"].ToString();
            
            instance.Extension = AppUtil.Util.ToExtensionType(row["extension"].ToString());
            instance.Libelle = row["libelle"].ToString();
            instance.MotCle = row["mot_cle"].ToString();

            if (!(row["fichier"] is DBNull))
                instance.Fichier = Convert.FromBase64String(row["fichier"].ToString());

            return instance;
        }
    }

}
