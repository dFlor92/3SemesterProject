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
            Dictionary<string, ServiceHost> hosts = new Dictionary<string, ServiceHost>
            {
                // Populate with names and instances
                { "AgentService", new ServiceHost(typeof(AgentService)) },
                { "MeetingService", new ServiceHost(typeof(MeetingService)) },
                { "CampaignService", new ServiceHost(typeof(CampaignService)) },
                { "LeadService", new ServiceHost(typeof(LeadService)) },
                { "SessionService", new ServiceHost(typeof(SessionService)) },
                { "SystemUserService", new ServiceHost(typeof(SystemUserService)) }
            };

            // Open all hosts
            foreach (var host in hosts)
            {
                host.Value.Open();
            }
            
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
                ((IDisposable)host.Value).Dispose();
            }

        }
    }
}
