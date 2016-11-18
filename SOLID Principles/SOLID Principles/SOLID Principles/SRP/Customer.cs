using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SOLID_Principles.SRP
{
    public class Customer
    {
        public int CustID { get; set; }
        public string Name { get; set; }
        public string city { get; set; }

        public List<Customer> LoadCustomers()
        {
            List<Customer> custList = new List<Customer>()
            {
              new Customer(){CustID=1,Name="Ramesh",city="Delhi"},
              new Customer(){CustID=2,Name="Suresh",city="Mumbai"},
              new Customer(){CustID=3,Name="Rahul",city="Kolkata"}

            };
            return custList;
        }
    }

}
