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
    class DBSession : ICRUD<Session>
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["MSSQL"].ConnectionString;

        public void Create(Session entity)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "INSERT INTO Session (date, duration) VALUES (@date, @duration)";
                    cmd.Parameters.AddWithValue("@name", entity.Date);
                    cmd.Parameters.AddWithValue("@description", entity.Duration);
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
                    cmd.CommandText = "DELETE FROM Session WHERE id = @id";
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public Session Read(int id)
        {
            Session temp = null;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM Session WHERE id = @id";
                    cmd.Parameters.AddWithValue("@id", id);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            temp = new Session(
                                        reader.GetInt32(0),
                                        reader.GetDateTime(1),
                                        reader.GetTimeSpan(2)
                                    );
                        }
                    }
                }
            }

            return temp;
        }

        public void Update(Session entity)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "UPDATE Session SET(date = @date, duration = @duration) WHERE id = @id";
                    cmd.Parameters.AddWithValue("@name", entity.Date);
                    cmd.Parameters.AddWithValue("@description", entity.Duration);
                    cmd.Parameters.AddWithValue("@id", entity.Id);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}

