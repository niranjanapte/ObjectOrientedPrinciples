using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SOLID_Principles.SRP;


namespace SOLID_Principles.LSP
{
    public abstract class CustomerCollection
    {
        public abstract void AddCustomer(Customer obj);
        public abstract int Count { get; }
    }

    public class SpecialCustomers : CustomerCollection
    {
        List<Customer> custlist = new List<Customer>();

        public override void AddCustomer(Customer obj)
        {
            custlist.Add(obj);
        }

        public override int Count
        {
            get
            {
                return custlist.Count;
            }
        }
    }

    public class TopNCustomers : CustomerCollection
    {
        private int count = 0;
        Customer[] list = new Customer[5];

        public override void AddCustomer(Customer obj)
        {
            if (count < 5)
            {
                list[count] = obj;
                count++;
            }
            else
            {
                throw new Exception("Only " + count + " customers can be added.");
            }
        }

        public override int Count
        {
            get
            {
                return list.Length;
            }
        }
    }
    /*
     * Now, the code has CustomerCollection abstract class with one property (Count) and one method (AddCustomer). 
     * The SpecialCustomers and TopNCustomers classes inherit from this abstract class and provide the concrete implementation for the Count and AddCustomer().
     * Notice that in this case TopNCustomers doesn't inherit from SpecialCustomers. */
}
