using Core;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer
{
    public class DBCampaign : ICRUD<Campaign>
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["MSSQL"].ConnectionString;

        public void Create(Campaign entity)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "INSERT INTO Campaign (name, description) VALUES (@name, @description)";
                    cmd.Parameters.AddWithValue("@name", entity.Name);
                    cmd.Parameters.AddWithValue("@description", entity.Description);
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
                    cmd.CommandText = "DELETE FROM Campaign WHERE id = @id";
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public Campaign Read(int id)
        {
            Campaign temp = null;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM Campaign WHERE id = @id";
                    cmd.Parameters.AddWithValue("@id", id);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            temp = new Campaign(
                                        reader.GetInt32(0),
                                        reader.GetString(1),
                                        reader.GetString(2)
                                    );
                        }
                    }
                }
            }

            return temp;
        }

        public void Update(Campaign entity)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "UPDATE Campaign SET(name = @name, description = @description) WHERE id = @id";
                    cmd.Parameters.AddWithValue("@name", entity.Name);
                    cmd.Parameters.AddWithValue("@description", entity.Description);
                    cmd.Parameters.AddWithValue("@id", entity.Id);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
