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
    public class DBLead : ICRUD<Lead>
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["MSSQL"].ConnectionString;

        public void Create(Lead entity)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "INSERT INTO Lead (name, phone, address) VALUES (@name, @phone, @address)";
                    cmd.Parameters.AddWithValue("@name", entity.Name);
                    cmd.Parameters.AddWithValue("@phone", entity.Phone);
                    cmd.Parameters.AddWithValue("@address", entity.Address);
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
                    cmd.CommandText = "DELETE FROM Lead WHERE id = @id";
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public Lead Read(int id)
        {
            Lead temp = null;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM Lead WHERE id = @id";
                    cmd.Parameters.AddWithValue("@id", id);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            temp = new Lead(
                                reader.GetInt32(0),
                                reader.GetString(1),
                                reader.GetString(2),
                                reader.GetString(3)
                            );
                        }
                    }
                }
            }

            return temp;
        }

        public void Update(Lead entity)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "UPDATE Lead SET(name = @name, phone = @phone, address = @address) WHERE id = @id";
                    cmd.Parameters.AddWithValue("@name", entity.Name);
                    cmd.Parameters.AddWithValue("@phone", entity.Phone);
                    cmd.Parameters.AddWithValue("@address", entity.Address);
                    cmd.Parameters.AddWithValue("@id", entity.Id);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
