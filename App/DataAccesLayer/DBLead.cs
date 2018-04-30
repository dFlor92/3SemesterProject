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
                    cmd.CommandText = "SELECT id as lead_id," +
                        "name as lead_name," +
                        "phone as lead_phone," +
                        "address as lead_address, " +
                        "status as lead_status, " +
                        "comment as lead_comment " +
                        "FROM Lead";

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

        public IEnumerable<Lead> AllUncalledLeads()
        {
            IEnumerable<Lead> temp = null;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "SELECT id as lead_id," +
                        "name as lead_name," +
                        "phone as lead_phone," +
                        "address as lead_address, " +
                        "status as lead_status, " +
                        "comment as lead_comment " +
                        "FROM Lead WHERE status = 0";

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
                    cmd.CommandText = "INSERT INTO Lead (name, phone, address, status, comment) VALUES (@name, @phone, @address, @status, @comment)";
                    cmd.Parameters.AddWithValue("@name", entity.Name);
                    cmd.Parameters.AddWithValue("@phone", entity.Phone);
                    cmd.Parameters.AddWithValue("@address", entity.Address);
                    cmd.Parameters.AddWithValue("@status", entity.Status);
                    cmd.Parameters.AddWithValue("@comment", entity.Comment);
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
                    cmd.CommandText = "SELECT id as lead_id," +
                        "name as lead_name," +
                        "phone as lead_phone," +
                        "address as lead_address, " +
                        "status as lead_status, " +
                        "comment as lead_comment " +
                        "FROM Lead WHERE id = @id" +
                        "";
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
                    cmd.CommandText = "UPDATE Lead SET(name = @name, phone = @phone, address = @address, status = @status, comment = @comment) WHERE id = @id";
                    cmd.Parameters.AddWithValue("@name", entity.Name);
                    cmd.Parameters.AddWithValue("@phone", entity.Phone);
                    cmd.Parameters.AddWithValue("@address", entity.Address);
                    cmd.Parameters.AddWithValue("@status", entity.Status);
                    cmd.Parameters.AddWithValue("@comment", entity.Comment);
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
                reader.GetString(reader.GetOrdinal("lead_address")), 
                (Core.LeadStatus)Enum.Parse(typeof(Core.LeadStatus), reader.GetInt32(reader.GetOrdinal("lead_status")).ToString()), // This is an int that needs to be an enum so we cast it to a role
                reader.GetString(reader.GetOrdinal("lead_comment"))
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
