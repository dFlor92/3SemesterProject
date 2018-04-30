using NobiWinClient.AgentService;
using NobiWinClient.CampaignService;
using NobiWinClient.LeadService;
using NobiWinClient.MeetingService;
using NobiWinClient.SystemUserService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NobiWinClient
{
    public partial class LeadDetails : Form
    {
        // Clients
        private CampaignServiceClient campaignClient;
        private AgentServiceClient agentClient;
        private SystemUserServiceClient userClient;
        private MeetingServiceClient meetingClient;

        // Hold the data
        private List<CampaignService.Campaign> campaigns;
        private List<AgentService.Agent> agents;
        private List<SystemUserService.SystemUser> callers;

        // Instance variables
        private LeadService.Lead lead;


        public LeadDetails(LeadService.Lead lead)
        {
            campaignClient = new CampaignServiceClient();
            campaigns = campaignClient.All();
            agentClient = new AgentServiceClient();
            agents = agentClient.All();
            meetingClient = new MeetingServiceClient();

            InitializeComponent();
            this.lead = lead;
        }
        
        private void fillData()
        {
            txt_id.Text = lead.Id+"";
            txt_name.Text = lead.Name;
            txt_phone.Text = lead.Phone;
            txt_address.Text = lead.Address;
            txt_status.Text = lead.Status+"";
            txt_comment.Text = lead.Comment;
            
        }

        private void LoadCampaigns()
        {
            for (int i = 0; i < campaigns.Count; i++)
            {
                campaign.Items.Add(campaigns.ElementAt(i).Name);
            }
        }
        private void LoadAgents()
        {
            for (int i = 0; i < agents.Count; i++)
            {
                agent.Items.Add(agents.ElementAt(i).Name);
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void LeadDetails_Load(object sender, EventArgs e)
        {
            fillData();
            LoadCampaigns();
            LoadAgents();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            AgentService.Agent temp = agents.ElementAt(agent.SelectedIndex);
            MeetingService.Meeting meeting = new MeetingService.Meeting
            {

                Date = datepicker.Value,
                Agent = new MeetingService.Agent
                {
                    Id = 1,
                    Campaign = new MeetingService.Campaign
                    {
                        Id = 1
                    }
                },
                Session = new MeetingService.Session
                {
                    Id = 4
                },
                Type = MeetingService.Type.Regular,
                Status = MeetingService.Status.Accepted
            };

            meetingClient.Create(meeting);


        }
    }
}
