using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles.OCP
{
    /* Statement
     * OCP: Software should be open for extension, but closed for modification.
     */
    public class TaxCalculator
    {
        public decimal CalculateTax(decimal amount, string country)
        {
            decimal taxAmount = 0;
            switch (country)
            {
                case "USA":
                    //calculate tax as per USA rules
                    break;
                case "UK":
                    //calculate tax as per UK rules
                    break;
                case "IN":
                    //calculate tax as per India rules
                    break;
            }
            return taxAmount;
        }
    }
    /* ocp voilation cause and solution
     *  If you also need to calculate tax in a few more countries. How will you take care of this additional functionality? You will change the CalculateTax() method and add additional cases inside the switch statement. 
     *  That means any change in the functionality is forcing you to change the core class - TaxCalculator. This is violation of OCP.
     *  Now, let's rewrite our code so that it follows OCP.
     */
    public abstract class TaxCalculatorBase
    {
        public decimal TotalAmount { get; set; }
        public abstract decimal CalculateTax();
    }

    public class USATax : TaxCalculatorBase
    {
        public override decimal CalculateTax()
        {
            //calculate tax as per USA rules
            return 0;
        }
    }

    public class UKTax : TaxCalculatorBase
    {
        public override decimal CalculateTax()
        {
            //calculate tax as per UK rules
            return 0;
        }
    }

    public class IndiaTax : TaxCalculatorBase
    {
        public override decimal CalculateTax()
        {
            //calculate tax as per India rules
            return 0;
        }
    }

    // Note: 
    /*
     * The above code creates an abstract class TaxCalculatorBase. This class defines a public property - TotalAmount - and an abstract method CalculateTax().
     * The CalculateTax() method doesn't have any code since it is an abstract method. The actual tax calculation happens in the derived classes - USATax, UKTax and IndiaTax. 
     * These classes provide the concrete implementation of the CalculateTax() method. 
     * Tomorrow if tax calculation is needed for a few more countries you need not modify any of the existing code. 
     * All you need to do is create another class that inherits from TaxCalculatorBase class and implement the required tax calculation logic inside its CalculateTax() method.
     */

}
