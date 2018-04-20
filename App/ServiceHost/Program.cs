using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using NobiService;

namespace Host
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ServiceHost host = new ServiceHost(typeof(AgentService)))
            {
                host.Open();
                Console.WriteLine("Press any key to kill host...");
                Console.ReadLine();
            }
        }
    }
}
