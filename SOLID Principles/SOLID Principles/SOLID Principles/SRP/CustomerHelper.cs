using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles.SRP
{
    /*
     * SRP - A class should have only a single responsibility. Only one potential change in the software's specification should be able to affect the specification of the class.
     */
    public class CustomerHelper
    {

        public List<Customer> GetAllCustomers()
        {
            return new Customer().LoadCustomers();
        }

        public Customer GetCustomerByID(int customerid)
        {

            return new Customer().LoadCustomers().Find(c => c.CustID == customerid);
        }

      /*  public string ExportCustomerData()
        {
            List<Customer> data = GetAllCustomers();
            StringBuilder sb = new System.Text.StringBuilder();
            foreach (Customer item in data)
            {
                sb.Append(item.CustID);
                sb.Append(",");
                sb.Append(item.Name);
                sb.Append(",");
                sb.Append(item.city);

            }
            return sb.ToString();
        }*/
    }

    /* The CustomerHelper class has three methods; GetAllCustomers(), GetCustomerByID() and ExportCustomerData(). the first two are fine here but adding ExportCustomerData() method violates SRP.
     *   A solution is to isolate this method in its own class as shown in the following code: */

    public class DataExporter
    {
        public string ExportCustomerData(List<Customer> data)
        {
            StringBuilder sb = new System.Text.StringBuilder();
            foreach (Customer item in data)
            {
                sb.Append(item.CustID);
                sb.Append(",");
                sb.Append(item.Name);
                sb.Append(",");
                sb.Append(item.city);
            }
            return sb.ToString();
        }
    }
    /*ExportCustomerData() method is now inside DataExporter class.
     * If there is any change in the data export format or logic only, DataExporter class will undergo a change whereas CustomerHelper class will remain unchanged.
     */
}
