using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WCFHelloWorld
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class CustomerService : ICustomerService
    {
        List<Customer> customerList;

        public CustomerService()
        {
            customerList = new List<Customer>();
            customerList.Add(new Customer {
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

            //DateTime resultDate = DateTime.MinValue;
            //DateTime.TryParseExact("22/02/1984", "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out resultDate);
            //
            //if (resultDate != DateTime.MinValue)
            //{
            //}
        }

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
