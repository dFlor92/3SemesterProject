using NobiWinClient.LeadService;
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
    public partial class testLeadList : Form
    {
        private Lead lead;
        private List<Lead> leadList;
        public testLeadList()
        {
            InitializeComponent();
            LoadLeads();
        }

        private void LoadLeads()
        {
            LeadServiceClient client = new LeadServiceClient();

            leadList = client.All();
            dataGridView1.DataSource = leadList;
            this.lead = leadList.First();
        }

        private void txtRefresh_Click(object sender, EventArgs e)
        {
            LeadDetails temp = new LeadDetails(this.lead);
            temp.Visible = true;
        }
    }
}
