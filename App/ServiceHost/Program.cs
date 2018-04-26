using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using Core;
using NobiService;

namespace Host
{
    class Program
    {
        // Temporary solution!
        // Creates a Dictionary<string, ServiceHost>
        static void Main(string[] args)
        {
            Dictionary<string, ServiceHost> hosts = new Dictionary<string, ServiceHost>();

            // Populate with names and instances
            hosts.Add("AgentService", new ServiceHost(typeof(AgentService)));
            hosts.Add("MeetingService", new ServiceHost(typeof(MeetingService)));
            hosts.Add("CampaignService", new ServiceHost(typeof(CampaignService)));
            hosts.Add("LeadService", new ServiceHost(typeof(LeadService)));
            hosts.Add("SessionService", new ServiceHost(typeof(SessionService)));
            hosts.Add("SystemUserService", new ServiceHost(typeof(SystemUserService)));

            // Open all hosts
            foreach (var host in hosts)
            {
                host.Value.Open();
            }

            ServiceHost action = null;
            // TEST THIS FUCKING SQL SHIT
            AgentService agentService = new AgentService();
            Agent tempAgent = agentService.Read(1);

            


            // Wait for user action
            Console.WriteLine("\nPress any key to terminate all services..");
            Console.ReadLine();

            // Close all hosts
            foreach (var host in hosts)
            {
                host.Value.Close();
            }

        }
    }
}
