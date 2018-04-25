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
    public class DBMeeting : IDatabaseCRUD<Meeting>
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["MSSQL"].ConnectionString;

        public IEnumerable<Meeting> All()
        {
            IEnumerable<Meeting> temp = null;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "SELECT meeting.id as meeting_id," +
                        "meeting.date as meeting_date," +
                        "meeting.type as meeting_type," +
                        "meeting.status as meeting_status," +
                        "meeting.agentId as meeting_agentId," +
                        "meeting.sessionId as meeting_sessionId," +
                        "agent.id as agent_id," +
                        "agent.name as agent_name," +
                        "agent.email as agent_email," +
                        "agent.phone as agent_phone," +
                        "agent.campaignId as agent_campaignId," +
                        "campaign.id as campaign_id," +
                        "campaign.name as campaign_name," +
                        "campaign.description as campaign_description," +
                        "session.id as session_id," +
                        "session.start as session_start," +
                        "session.end as session_end," +
                        "session.systemUserId as session_systemUserId," +
                        "session.leadId as session_leadId," +
                        "systemUser.id as systemUser_id," +
                        "systemUser.name as systemUser_name," +
                        "systemUser.email as systemUser_email," +
                        "systemUser.phone as systemUser_phone," +
                        "systemUser.password as systemUser_password," +
                        "systemUser.role as systemUser_role," +
                        "lead.id as lead_id," +
                        "lead.name as lead_name," +
                        "lead.phone as lead_phone," +
                        "lead.address as lead_address " +
                        "FROM Meeting " +
                        "JOIN Agent ON (agent.id = meeting.agentId) " +
                        "JOIN Campaign ON (campaign.id = agent.campaignId) " +
                        "JOIN Session ON (session.id = meeting.sessionId) " +
                        "JOIN SystemUser ON (systemUser.id = session.systemUserId) " +
                        "JOIN Lead ON (lead.id = session.leadId)";

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

        public void Create(Meeting entity)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "INSERT INTO Meeting (date, type, status, agentId, sessionId) VALUES (@date, @type, @status, @agentId, @sessionId)";
                    cmd.Parameters.AddWithValue("@date", entity.Date);
                    cmd.Parameters.AddWithValue("@type", entity.Type);
                    cmd.Parameters.AddWithValue("@status", entity.Status);
                    cmd.Parameters.AddWithValue("@agentId", entity.Agent.Id);
                    cmd.Parameters.AddWithValue("@sessionId", entity.Session.Id);
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
                    cmd.CommandText = "DELETE FROM Meeting WHERE id = @id";
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public Meeting Read(int id)
        {
            Meeting temp = null;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "SELECT meeting.id as meeting_id," +
                        "meeting.date as meeting_date," +
                        "meeting.type as meeting_type," +
                        "meeting.status as meeting_status," +
                        "meeting.agentId as meeting_agentId," +
                        "meeting.sessionId as meeting_sessionId," +
                        "agent.id as agent_id," +
                        "agent.name as agent_name," +
                        "agent.email as agent_email," +
                        "agent.phone as agent_phone," +
                        "agent.campaignId as agent_campaignId," +
                        "campaign.id as campaign_id," +
                        "campaign.name as campaign_name," +
                        "campaign.description as campaign_description," +
                        "session.id as session_id," +
                        "session.start as session_start," +
                        "session.end as session_end," +
                        "session.systemUserId as session_systemUserId," +
                        "session.leadId as session_leadId," +
                        "systemUser.id as systemUser_id," +
                        "systemUser.name as systemUser_name," +
                        "systemUser.email as systemUser_email," +
                        "systemUser.phone as systemUser_phone," +
                        "systemUser.password as systemUser_password," +
                        "systemUser.role as systemUser_role," +
                        "lead.id as lead_id," +
                        "lead.name as lead_name," +
                        "lead.phone as lead_phone," +
                        "lead.address as lead_address " +
                        "FROM Meeting " +
                        "JOIN Agent ON (agent.id = meeting.agentId) " +
                        "JOIN Campaign ON (campaign.id = agent.campaignId) " +
                        "JOIN Session ON (session.id = meeting.sessionId) " +
                        "JOIN SystemUser ON (systemUser.id = session.systemUserId) " +
                        "JOIN Lead ON (lead.id = session.leadId) " +
                        "WHERE meeting.id = @id"; 
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

        public void Update(Meeting entity)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "UPDATE Meeting SET(date = @date, type = @type, status = @status, agentId = @agentId, sessionId = @sessionId) where id = @id";
                    cmd.Parameters.AddWithValue("@date", entity.Date);
                    cmd.Parameters.AddWithValue("@type", entity.Type);
                    cmd.Parameters.AddWithValue("@status", entity.Status);
                    cmd.Parameters.AddWithValue("@agentId", entity.Agent.Id);
                    cmd.Parameters.AddWithValue("@sessionId", entity.Session.Id);
                    cmd.Parameters.AddWithValue("@Id", entity.Id);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        internal static Meeting BuildObject(SqlDataReader reader)
        {
            return new Meeting(
                reader.GetInt32(reader.GetOrdinal("meeting_id")),
                reader.GetDateTime(reader.GetOrdinal("meeting_date")),
                (Core.Type)Enum.Parse(typeof(Core.Type), reader.GetInt32(reader.GetOrdinal("meeting_type")).ToString()), // This is an int that needs to be an enum so we cast it to a role
                (Core.Status)Enum.Parse(typeof(Core.Status), reader.GetInt32(reader.GetOrdinal("meeting_status")).ToString()), // This is an int that needs to be an enum so we cast it to a role
                DBAgent.BuildObject(reader),
                DBSession.BuildObject(reader)
            );
        }

        internal static IEnumerable<Meeting> BuildObjects(SqlDataReader reader)
        {
            List<Meeting> temp = new List<Meeting>();

            while(reader.Read())
            {
                temp.Add(BuildObject(reader));
            }

            return temp;
        }

    }
}

    

