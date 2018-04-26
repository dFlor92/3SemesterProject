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
    public class DBSystemUser : IDatabaseCRUD<SystemUser>
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["MSSQL"].ConnectionString;

        public IEnumerable<SystemUser> All()
        {
            IEnumerable<SystemUser> temp = null;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "SELECT id as systemUser_id," +
                        "name as systemUser_name," +
                        "email as systemUser_email," +
                        "phone as systemUser_phone," +
                        "password as systemUser_password," +
                        "role as systemUser_role " +
                        "FROM SystemUser";

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

        public void Create(SystemUser entity)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "INSERT INTO SystemUser (name, email, role) VALUES (@name, @email, @role)";
                    cmd.Parameters.AddWithValue("@name", entity.Name);
                    cmd.Parameters.AddWithValue("@description", entity.Email);
                    cmd.Parameters.AddWithValue("@role", entity.Role);
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
                    cmd.CommandText = "DELETE FROM SystemUser WHERE id = @id";
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public SystemUser Read(int id)
        {
            SystemUser temp = null;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "SELECT id as systemUser_id," +
                        "name as systemUser_name," +
                        "email as systemUser_email," +
                        "phone as systemUser_phone," +
                        "password as systemUser_password," +
                        "role as systemUser_role " +
                        "FROM SystemUser " +
                        "WHERE id = @id";
                    cmd.Parameters.AddWithValue("@id", id);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            temp = BuildObject(reader);
                        }
                    }
                }
            }

            return temp;
        }

        public void Update(SystemUser entity)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "UPDATE SystemUser SET(name = @name, email = @email, role = @role) WHERE id = @id";
                    cmd.Parameters.AddWithValue("@name", entity.Name);
                    cmd.Parameters.AddWithValue("@description", entity.Email);
                    cmd.Parameters.AddWithValue("@Role", entity.Role);
                    cmd.Parameters.AddWithValue("@id", entity.Id);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        internal static SystemUser BuildObject(SqlDataReader reader)
        {
            return new SystemUser(
                reader.GetInt32(reader.GetOrdinal("systemUser_id")),
                reader.GetString(reader.GetOrdinal("systemUser_name")),
                reader.GetString(reader.GetOrdinal("systemUser_email")),
                reader.GetString(reader.GetOrdinal("systemUser_phone")),
                reader.GetString(reader.GetOrdinal("systemUser_password")),
                (Role)Enum.Parse(typeof(Role), reader.GetInt32(reader.GetOrdinal("systemUser_role")).ToString()) // This is an int that needs to be an enum so we cast it to a role
            );
        }

        internal static IEnumerable<SystemUser> BuildObjects(SqlDataReader reader)
        {
            List<SystemUser> temp = new List<SystemUser>();

            while (reader.Read())
            {
                temp.Add(BuildObject(reader));
            }

            return temp;
        }
    }
}

