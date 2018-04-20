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
    public class DBCampaign : IDatabaseCRUD<Campaign>
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["MSSQL"].ConnectionString;

        public IEnumerable<Campaign> All()
        {
            List<Campaign> temp = new List<Campaign>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "SELECT campaign.id as campaign_name," +
                        "campaign.name as campaign_name" +
                        "campaign.description as campaign_description" +
                        " FROM Campaign";

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
                    cmd.CommandText = "SELECT campaign.id as campaign_name," +
                        "campaign.name as campaign_name" +
                        "campaign.description as campaign_description" +
                        " FROM Campaign WHERE campaign.id = @id";
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

        internal static Campaign BuildObject(SqlDataReader reader)
        {
            return new Campaign(
                reader.GetInt32(reader.GetOrdinal("campaign_id")),
                reader.GetString(reader.GetOrdinal("campaign_name")),
                reader.GetString(reader.GetOrdinal("campaign_description"))
            );
        }

        internal static List<Campaign> BuildObjects(SqlDataReader reader)
        {
            List<Campaign> temp = new List<Campaign>();

            while (reader.Read())
            {
                temp.Add(BuildObject(reader));
            }

            return temp;
        }
    }
}
