using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.ServiceModel.Web;
using System.Text;

namespace WCFHelloWorld
{
    [ServiceBehavior(InstanceContextMode=InstanceContextMode.PerSession)]
    public class CustomerService : ICustomerService
    {
        List<Customer> customerList;

        public CustomerService()
        {
            //DateTime resultDate = DateTime.MinValue;
            //DateTime.TryParseExact("22/02/1984", "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out resultDate);
            //
            //if (resultDate != DateTime.MinValue)
            //{
            //}
        }

        public void AddCustomer(Customer customer)
        {
            customerList = new List<Customer>();
            customerList.Add(new Customer
            {
                Id = 1,
                Abilitato = true,
                Nome = "Antonio",
                Cognome = "Liccardi",
                Azienda = "Overnet",
                DataNascita = DateTime.Now,
                Sconto = 10.45M
            });

            customerList.Add(new Customer
            {
                Id = 2,
                Abilitato = true,
                Nome = "Giuseppe",
                Cognome = "Esposito",
                Azienda = "Overnet",
                DataNascita = DateTime.Now,
                Sconto = 4.32M
            });

            customerList.Add(new Customer
            {
                Id = 3,
                Abilitato = false,
                Nome = "Michele",
                Cognome = "Contino",
                Azienda = "Overnet",
                DataNascita = DateTime.ParseExact("22/02/1984", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                Sconto = 4
            });

            customerList.Add(customer);
        }

        [WebInvoke(Method = "GET",
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "customer/{id}")]
        public Customer GetCustomerById(int id)
        {
            //return customerList.Where(x => x.Id == id).FirstOrDefault();
            return customerList.FirstOrDefault(x => x.Id == id)  ?? new Customer();
        }

        public List<Customer> GetCustomers()
        {
            return customerList;
        }
    }
}
