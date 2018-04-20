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
    class DBSystemUser : IDatabaseCRUD<SystemUser>
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["MSSQL"].ConnectionString;

        public IEnumerable<SystemUser> All()
        {
            List<SystemUser> temp = new List<SystemUser>();

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
                            temp = BuildMany(reader);
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
                    cmd.CommandText = "SELECT * FROM SystemUser WHERE id = @id";
                    cmd.Parameters.AddWithValue("@id", id);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            temp = build(reader);
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

        private SystemUser build(SqlDataReader reader)
        {
            return new SystemUser(
                reader.GetInt32(0),
                reader.GetString(1),
                reader.GetString(2),
                (Role)Enum.Parse(typeof(Role), reader.GetInt32(3).ToString()) // This is an int that needs to be an enum so we cast it to a role
            );
        }

        private List<SystemUser> BuildMany(SqlDataReader reader)
        {
            List<SystemUser> temp = new List<SystemUser>();

            while (reader.Read())
            {
                temp.Add(build(reader));
            }

            return temp;
        }
    }
}

