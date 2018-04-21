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
            List<Session> temp = new List<Session>();

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
                    cmd.CommandText = "INSERT INTO Session (date, duration, systemUserId, leadId) VALUES (@date, @duration, @systemUserId, @leadId)";
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
                    cmd.CommandText = "DELETE FROM Session WHERE id = @id";
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
                    cmd.CommandText = "SELECT * FROM Session WHERE id = @id";
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
                    cmd.CommandText = "UPDATE Session SET(date = @date, duration = @duration, systemUserId = @systemUserId, leadId = @leadId) WHERE id = @id";
                    cmd.Parameters.AddWithValue("@name", entity.Date);
                    cmd.Parameters.AddWithValue("@description", entity.Duration);
                    cmd.Parameters.AddWithValue("@systemUserId", entity.SystemUser.Id);
                    cmd.Parameters.AddWithValue("@leadId", entity.Lead.Id);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        private Session BuildObject(SqlDataReader reader)
        {
            return new Session(
                reader.GetInt32(0),
                reader.GetDateTime(1),
                reader.GetTimeSpan(2),
                new SystemUser(reader.GetInt32(3)),
                new Lead(reader.GetInt32(4))
            );
        }

        private List<Session> BuildObjects(SqlDataReader reader)
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

