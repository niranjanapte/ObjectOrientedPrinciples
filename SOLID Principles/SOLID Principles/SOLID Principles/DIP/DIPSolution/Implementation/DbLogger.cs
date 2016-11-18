using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SOLID_Principles.DIP.DIPSolution.Interfaces;

namespace SOLID_Principles.DIP.DIPSolution.Implementation
{
    public class DbLogger : ILogger
    {
        public void LogMessage(string aMessage)
        {
            //Code to write message in database.  
        }
    } 
}
