using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WCFHelloWorldClient.CustomerServiceReference;

namespace WCFHelloWorldClient
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerServiceClient client = new CustomerServiceClient();
            var customers = client.GetCustomers();
        }
    }
}
