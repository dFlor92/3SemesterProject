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
    public class DBAgent : IDatabaseCRUD<Agent>
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["MSSQL"].ConnectionString;

        public IEnumerable<Agent> All()
        {
            IEnumerable<Agent> temp = null;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM Agent JOIN Campaign ON (campaign_id = agent_campaignId)";

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

        public void Create(Agent entity)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "INSERT INTO Agent (agent_name, agent_email, agent_campaign) VALUES (@name, @email, @campaign)";
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
                    cmd.CommandText = "DELETE FROM Agent WHERE agent_id = @id";
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
                    cmd.CommandText = "SELECT * FROM Agent JOIN Campaign ON (campaign_id = agent_campaignId) WHERE agent_id = @id";
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

        public void Update(Agent entity)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "UPDATE Agent SET(agent_name = @name, agent_email = @email, agent_campaign = @campaign) WHERE agent_id = @id";
                    cmd.Parameters.AddWithValue("@name", entity.Name);
                    cmd.Parameters.AddWithValue("@email", entity.Email);
                    cmd.Parameters.AddWithValue("@campaign", entity.Campaign);
                    cmd.Parameters.AddWithValue("@id", entity.Id);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        internal static Agent BuildObject(SqlDataReader reader)
        {
            Campaign temp = DBCampaign.BuildObject(reader);
            return new Agent(
                reader.GetInt32(reader.GetOrdinal("agent_id")),
                reader.GetString(reader.GetOrdinal("agent_name")),
                reader.GetString(reader.GetOrdinal("agent_email")),
                reader.GetString(reader.GetOrdinal("agent_phone")),
                temp
            );
        }

        internal static IEnumerable<Agent> BuildObjects(SqlDataReader reader)
        {
            List<Agent> temp = new List<Agent>();

            while (reader.Read())
            {
                temp.Add(BuildObject(reader));
            }

            return temp;

        }

      
    }
}

