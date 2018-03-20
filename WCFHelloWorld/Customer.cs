using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WCFHelloWorld
{
    [DataContract]
    public class Customer
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string Nome { get; set; }

        [DataMember]
        public string Cognome { get; set; }

        [DataMember]
        public string Azienda { get; set; }

        [DataMember]
        public DateTime DataNascita { get; set; }

        [DataMember]
        public decimal Sconto { get; set; }

        [DataMember]
        public bool Abilitato { get; set; }
    }
}