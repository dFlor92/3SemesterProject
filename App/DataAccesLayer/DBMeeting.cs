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
    public class DBMeeting : ICRUD<Meeting>
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["MSSQL"].ConnectionString;

        public void Create(Meeting entity)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "INSERT INTO Meeting (date, type, status, agent, lead) VALUES (@date, @type, @status, @agent, @lead)";
                    cmd.Parameters.AddWithValue("@date", entity.Date);
                    cmd.Parameters.AddWithValue("@name", entity.Type);
                    cmd.Parameters.AddWithValue("@name", entity.Status);
                    cmd.Parameters.AddWithValue("@name", entity.Agent);
                    cmd.Parameters.AddWithValue("@description", entity.Lead);
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
                            temp = new Meeting(
                                        reader.GetInt32(0),
                                        reader.GetDateTime(1),
                                        reader.GetInt32(2),
                                        reader.GetInt32(3),
                                        reader.GetInt32(4),
                                        reader.GetInt32(5)
                                    );
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
                    cmd.CommandText = "UPDATE Meeting SET(date, type, status, agent, lead) where id = @id";
                    cmd.Parameters.AddWithValue("@date", entity.Date);
                    cmd.Parameters.AddWithValue("@type", entity.Type);
                    cmd.Parameters.AddWithValue("@status", entity.Status);
                    cmd.Parameters.AddWithValue("@agent", entity.Agent);
                    cmd.Parameters.AddWithValue("@description", entity.Lead);
                    cmd.Parameters.AddWithValue("@Id", entity.Id);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}

    

