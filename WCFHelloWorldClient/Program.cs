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

            //client.AddCustomer(new Customer
            //{
            //    Abilitato = true,
            //    Id = 4,
            //    Azienda = "Overnet",
            //    Nome = "Pippo",
            //    Cognome = "Esposito"
            //});

            var customers = client.GetCustomerById(1);
        }
    }
}
