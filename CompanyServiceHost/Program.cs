using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using CompanyService;

namespace CompanyServiceHost {
    class Program {
        static void Main(string[] args) {
            using (ServiceHost host = new ServiceHost(typeof(CompanyService.CompanyService))) {
                host.Open();
                Console.WriteLine("Host started @ " + DateTime.Now);
                Console.ReadLine();
            }
        }
    }
}
