using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
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
                    cmd.CommandText = "SELECT agent.id as agent_id," +
                        "agent.name as agent_name," +
                        "agent.email as agent_email," +
                        "agent.phone as agent_phone," +
                        "agent.campaignId as agent_campaignId, " +
                        "campaign.id as campaign_id," +
                        "campaign.name as campaign_name," +
                        "campaign.description as campaign_description " +
                        "FROM Agent " +
                        "JOIN Campaign " +
                        "ON (campaign.id = agent.campaignId) " +
                        "WHERE agent.id = @id";

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
                    cmd.CommandText = "INSERT INTO Agent (name, email, campaign) VALUES (@name, @email, @campaign)";
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
                    cmd.CommandText = "DELETE FROM Agent WHERE id = @id";
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
                    cmd.CommandText = "SELECT agent.id as agent_id," +
                        "agent.name as agent_name," +
                        "agent.email as agent_email," +
                        "agent.phone as agent_phone," +
                        "agent.campaignId as agent_campaignId, " +
                        "campaign.id as campaign_id," +
                        "campaign.name as campaign_name," +
                        "campaign.description as campaign_description " +
                        "FROM Agent " +
                        "JOIN Campaign " +
                        "ON (campaign.id = agent.campaignId) " +
                        "WHERE agent.id = @id";
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
                    cmd.CommandText = "UPDATE Agent SET(name = @name, email = @email, campaign = @campaign) WHERE id = @id";
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

