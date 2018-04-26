
using NobiWinClient.AgentService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NobiWinClient
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AgentServiceClient client = new AgentServiceClient();
            Agent agent = client.Read(Int32.Parse(txt1.Text));
            if (agent != null)
            {
                txt2.Text = agent.Name;
                txt3.Text = agent.Email;
                txt4.Text = agent.Phone;
                txt5.Text = agent.Campaign.Name;
            }
            else
            {
                MessageBox.Show("Der findes ingen agent med id: " + txt1.Text);
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtRefresh_Click(object sender, EventArgs e)
        {
            AgentDataSet();
        }

        private void AgentDataSet()
        {
            AgentServiceClient client = new AgentServiceClient();

            IEnumerable<Agent> agents = client.All();

            dataGridView1.DataSource = agents;
            //    DataGridViewRow row = dataGridView1.Rows[0];
            //    if (agents != null)
            //       foreach (Agent agent in agents)

            //        {
            //            row.Cells[0].Value = agent.Id;
            //            row.Cells[1].Value = agent.Name;
            //            row.Cells[2].Value = agent.Email;
            //            row.Cells[3].Value = agent.Phone;
            //          row.Cells[4].Value = agent.Campaign.Name;
            //            //... lot more properties
            //         }

            //        else
            //        {
            //            MessageBox.Show("Der findes ingen agent med id: " + txt1.Text);
            //        }

            //    }

            //}

        }

        
    }
}


    

