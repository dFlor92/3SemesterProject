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
                    cmd.CommandText = "SELECT * FROM Meeting";

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
                    cmd.CommandText = "INSERT INTO Meeting (meeting_date, meeting_type, meeting_status, meeting_agentId, meeting_sessionId) VALUES (@date, @type, @status, @agentId, @sessionId)";
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
                    cmd.CommandText = "DELETE FROM Meeting WHERE meeting_id = @id";
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
                    cmd.CommandText = "SELECT * FROM Meeting " +
                        "JOIN Agent ON (agent_id = meeting_agentId) " +
                        "JOIN Lead ON (lead_id = meeting_leadId) " +
                        "WHERE meeting_id = @id";
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
                    cmd.CommandText = "UPDATE Meeting SET(meeting_date = @date, meeting_type = @type, meeting_status = @status, meeting_agentId = @agentId, meeting_sessionId = @sessionId) where meeting_id = @id";
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

        internal static Meeting buildObject(SqlDataReader reader)
        {
            return new Meeting(
                reader.GetInt32(reader.GetOrdinal("meeting_id")),
                reader.GetDateTime(reader.GetOrdinal("meeting_date")),
                reader.GetInt32(reader.GetOrdinal("meeting_type")),
                reader.GetInt32(reader.GetOrdinal("meeting_status")),
                DBAgent.BuildObject(reader),
                DBSession.BuildObject(reader)
            );
        }

        internal static List<Meeting> BuildObjects(SqlDataReader reader)
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

    

