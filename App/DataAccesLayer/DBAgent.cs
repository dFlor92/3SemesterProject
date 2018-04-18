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
    class DBAgent : ICRUD<Agent>
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["MSSQL"].ConnectionString;

        public void Create(Agent entity)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "INSERT INTO Agent (name, email, campaign) VALUES (@name, @email, @campaign)";
                    cmd.Parameters.AddWithValue("@name", entity.Name);
                    cmd.Parameters.AddWithValue("@email", entity.Email);
                    cmd.Parameters.AddWithValue("@campaign", entity.Campaign);
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
                    cmd.CommandText = "DELETE FROM Agent WHERE id = @id";
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public Agent Read(int id)
        {
            Agent temp = null;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM Agent WHERE id = @id";
                    cmd.Parameters.AddWithValue("@id", id);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            temp = new Agent(
                                        reader.GetInt32(0),
                                        reader.GetString(1),
                                        reader.GetString(2),
                                        reader.GetInt32(3)
                                    );
                        }
                    }
                }
            }

            return temp;
        }

        public void Update(Agent entity)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "UPDATE Agent SET(name = @name, email = @email, campaign = @campaign) WHERE id = @id";
                    cmd.Parameters.AddWithValue("@name", entity.Name);
                    cmd.Parameters.AddWithValue("@email", entity.Email);
                    cmd.Parameters.AddWithValue("@campaign", entity.Campaign);
                    cmd.Parameters.AddWithValue("@id", entity.Id);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}

