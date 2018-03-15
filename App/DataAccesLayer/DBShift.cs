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
    public class DBShift : ICRUD<Shift>
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["MSSQL"].ConnectionString;

        public void Create(Shift entity)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "INSERT INTO Shift (Start, Slut) VALUES (@start, @end)";
                    cmd.Parameters.AddWithValue("@start", entity.Start);
                    cmd.Parameters.AddWithValue("@end", entity.End);
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
                    cmd.CommandText = "DELETE FROM Shift WHERE Id = @id";
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public Shift Read(int id)
        {
            Shift temp = null;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM Shift WHERE Id = @id";
                    cmd.Parameters.AddWithValue("@id", id);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            temp = new Shift(
                                reader.GetInt32(0),
                                reader.GetDateTime(1),
                                reader.GetDateTime(2),
                                new Employee(reader.GetInt32(3)));
                        }
                    }
                }
            }

            return temp;
        }

        public void Update(Shift entity)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "UPDATE Shift SET(Start = @start, End = @end, EmployeeId = @employeeId) WHERE Id = @id";
                    cmd.Parameters.AddWithValue("@start", entity.Start);
                    cmd.Parameters.AddWithValue("@end", entity.End);
                    cmd.Parameters.AddWithValue("@employeeId", entity.Employee.Id);
                    cmd.Parameters.AddWithValue("@id", entity.Id);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
