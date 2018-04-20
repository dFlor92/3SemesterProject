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
    public class DBMeeting : IDatabaseCRUD<Meeting>
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["MSSQL"].ConnectionString;

        public IEnumerable<Meeting> All()
        {
            List<Meeting> temp = new List<Meeting>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM SystemUser";

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            temp = BuildObjects(reader);
                        }
                    }
                }
            }

            return temp;
        }

        public void Create(Meeting entity)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "INSERT INTO Meeting (date, type, status, agentId, sessionId) VALUES (@date, @type, @status, @agentId, @sessionId)";
                    cmd.Parameters.AddWithValue("@date", entity.Date);
                    cmd.Parameters.AddWithValue("@type", entity.Type);
                    cmd.Parameters.AddWithValue("@status", entity.Status);
                    cmd.Parameters.AddWithValue("@agentId", entity.Agent.Id);
                    cmd.Parameters.AddWithValue("@sessionId", entity.Session.Id);
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
                    cmd.CommandText = "DELETE FROM Meeting WHERE id = @id";
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public Meeting Read(int id)
        {
            Meeting temp = null;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM Meeting JOIN Agent on(agent.id = Meeting.agentId) JOIN Lead on(lead.id = Meeting.leadId) WHERE id = @id";
                    cmd.Parameters.AddWithValue("@id", id);
                    
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            temp = buildObject(reader);
                        }
                    }
                }
            }

            return temp;
        }

        public void Update(Meeting entity)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "UPDATE Meeting SET(date = @date, type = @type, status = @status, agentId = @agentId, sessionId = @sessionId) where id = @id";
                    cmd.Parameters.AddWithValue("@date", entity.Date);
                    cmd.Parameters.AddWithValue("@type", entity.Type);
                    cmd.Parameters.AddWithValue("@status", entity.Status);
                    cmd.Parameters.AddWithValue("@agentId", entity.Agent.Id);
                    cmd.Parameters.AddWithValue("@sessionId", entity.Session.Id);
                    cmd.Parameters.AddWithValue("@Id", entity.Id);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private Meeting buildObject(SqlDataReader reader)
        {
            return new Meeting(
                reader.GetInt32(0),
                reader.GetDateTime(1),
                reader.GetInt32(2),
                reader.GetInt32(3),
                new Agent(reader.GetInt32(4)),
                new Session(reader.GetInt32(5))
            );
        }

        private List<Meeting> BuildObjects(SqlDataReader reader)
        {
            List<Meeting> temp = new List<Meeting>();

            while(reader.Read())
            {
                temp.Add(buildObject(reader));
            }

            return temp;
        }

    }
}

    

