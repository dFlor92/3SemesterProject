using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core;

namespace DataAccesLayer
{
    public class DBSession : IDatabaseCRUD<Session>
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["MSSQL"].ConnectionString;

        public IEnumerable<Session> All()
        {
            IEnumerable<Session> temp = null;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM Session";

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            temp = BuildObjects(reader);
                        }
                    }
                }
            }

            return temp;
        }

        public void Create(Session entity)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "INSERT INTO Session (session_date, session_duration, session_systemUserId, session_leadId) VALUES (@date, @duration, @systemUserId, @leadId)";
                    cmd.Parameters.AddWithValue("@name", entity.Date);
                    cmd.Parameters.AddWithValue("@description", entity.Duration);
                    cmd.Parameters.AddWithValue("@systemUserId", entity.SystemUser.Id);
                    cmd.Parameters.AddWithValue("@leadId", entity.Lead.Id);
                    cmd.ExecuteNonQuery();

              
                }
            }
        }

        public void Delete(int id)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "DELETE FROM Session WHERE session_id = @id";
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public Session Read(int id)
        {
            Session temp = null;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM Session WHERE session_id = @id";
                    cmd.Parameters.AddWithValue("@id", id);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            temp = BuildObject(reader);
                        }
                    }
                }
            }

            return temp;
        }

        public void Update(Session entity)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "UPDATE Session SET(session_date = @date, session_duration = @duration, session_systemUserId = @systemUserId, leadId = @leadId) WHERE session_id = @id";
                    cmd.Parameters.AddWithValue("@name", entity.Date);
                    cmd.Parameters.AddWithValue("@description", entity.Duration);
                    cmd.Parameters.AddWithValue("@systemUserId", entity.SystemUser.Id);
                    cmd.Parameters.AddWithValue("@leadId", entity.Lead.Id);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        internal static Session BuildObject(SqlDataReader reader)
        {
            return new Session(
                reader.GetInt32(reader.GetOrdinal("session_id")),
                reader.GetDateTime(reader.GetOrdinal("session_start")),
                reader.GetDateTime(reader.GetOrdinal("session_end")),
                DBSystemUser.BuildObject(reader),
                DBLead.BuildObject(reader)
            );
        }

        internal static IEnumerable<Session> BuildObjects(SqlDataReader reader)
        {
            List<Session> temp = new List<Session>();

            while (reader.Read())
            {
                temp.Add(BuildObject(reader));
            }

            return temp;
        }
    }
}

