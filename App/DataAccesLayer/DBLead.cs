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
    public class DBLead : IDatabaseCRUD<Lead>
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["MSSQL"].ConnectionString;

        public IEnumerable<Lead> All()
        {
            IEnumerable<Lead> temp = null;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM Lead";

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

        public void Create(Lead entity)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "INSERT INTO Lead (lead_name, lead_phone, lead_address) VALUES (@name, @phone, @address)";
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
                    cmd.CommandText = "DELETE FROM Lead WHERE lead_id = @id";
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
                    cmd.CommandText = "SELECT * FROM Lead WHERE lead_id = @id";
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

        public void Update(Lead entity)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "UPDATE Lead SET(lead_name = @name, lead_phone = @phone, lead_address = @address) WHERE lead_id = @id";
                    cmd.Parameters.AddWithValue("@name", entity.Name);
                    cmd.Parameters.AddWithValue("@phone", entity.Phone);
                    cmd.Parameters.AddWithValue("@address", entity.Address);
                    cmd.Parameters.AddWithValue("@id", entity.Id);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        internal static Lead BuildObject(SqlDataReader reader)
        {
            return new Lead(
                reader.GetInt32(reader.GetOrdinal("lead_id")),
                reader.GetString(reader.GetOrdinal("lead_name")),
                reader.GetString(reader.GetOrdinal("lead_phone")),
                reader.GetString(reader.GetOrdinal("lead_address"))
            );
        }

        internal static IEnumerable<Lead> BuildObjects(SqlDataReader reader)
        {
            List<Lead> temp = new List<Lead>();

            while (reader.Read())
            {
                temp.Add(BuildObject(reader));
            }

            return temp;
        }
    }
}
