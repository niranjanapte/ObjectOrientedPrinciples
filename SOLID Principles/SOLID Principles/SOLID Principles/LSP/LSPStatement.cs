using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SOLID_Principles.SRP;
namespace SOLID_Principles.LSP
{
    /* Statement
   * LSP: Objects in a program should be replaceable with instances of their subtypes without altering the correctness of that program.
   * Note: You must be aware that you can use an object of a derived class anywhere where base class is expected. However, when such a substitution occurs the functionality and correctness of the code shouldn't change
   */
    public class SpecialCustomers
    {
        List<Customer> list = new List<Customer>();

        public virtual void AddCustomer(Customer obj)
        {
            list.Add(obj);
        }

        public int Count
        {
            get
            {
                return list.Count;
            }
        }
    }
    public class TopNCustomers : SpecialCustomers
    {
        private int maxCount = 5;

        public override void AddCustomer(Customer obj)
        {
            if (Count < maxCount)
            {
                AddCustomer(obj);
            }
            else
            {
                throw new Exception("Only " + maxCount + " customers can be added.");
            }
        }
    }
}
