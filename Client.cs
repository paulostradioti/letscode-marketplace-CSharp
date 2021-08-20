using System;

namespace ProjetoLetsCode2
{
    public class Client
    {
        public int id { get; set; }

        public string name { get; set; }

        public Address deliveryAddress { get; set; }
        public Address billingAddress { get; set; }

        public string user { get; set; }

        public string password { get; set; }

        public DateTime birthDate { get; set; }
    }
}