using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SOLID_Principles.SRP;
using SOLID_Principles.LSP;

namespace SOLID_Principles
{
    class Program
    {
        static void Main(string[] args)
        {
            // SRP problem solving.
            CustomerHelper objCust = new CustomerHelper();
            foreach (var item in  objCust.GetAllCustomers())
            {
                Console.WriteLine("Customer Data \n ID: {0}, Name: {1}, City: {2}",item.CustID,item.Name,item.city);
            }
           // LSP PROBLEM
            SpecialCustomers sc = null;
            sc = new TopNCustomers();
            for (int i = 0; i < 10; i++)
            {
                Customer obj = new Customer();
                sc.AddCustomer(obj);
            }
            /* Problem 
             *  The problem comes in the for loop. The for loop that follows attempts to add 10 Customer instances to the TopNCustomers. 
             *  But TopNCustomers allows only 5 instances and hence throws an error. 
             *  If sc would have been of type SpecialCustomers the for loop would have successfully added 10 instances into the List. 
             *  However, since the code substitutes TopNCustomers instance in place of SpecialCustomers the code produces an exception. 
             *  Thus LSP is violated in this example.
             */
            // LSP SOLUTION TO ABOVE PROBLEM
            Customer c = new Customer() { CustID = "ALFKI" };
            CustomerCollection collection = null;
            collection = new SpecialCustomers();
            collection.AddCustomer(c);
            collection = new TopNCustomers();
            collection.AddCustomer(c);
            /* NOTE: 
             * The above code declares a variable of CustomerCollection type. Once it points to an instance of SpecialCustomers and then to TopNCustomers. 
             * In this case, however, their base class is CustomerCollection and the instances are perfectly substitutable for it without producing any inaccuracies.
             * */

        }
    }
}
