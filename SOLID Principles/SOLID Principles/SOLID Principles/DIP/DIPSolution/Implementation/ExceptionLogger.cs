using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SOLID_Principles.DIP.DIPSolution.Interfaces;

namespace SOLID_Principles.DIP.DIPSolution.Implementation
{
    /*Now, we move to the low-level class's intitiation from the ExcetpionLogger class to the DataExporter class 
     * to make ExceptionLogger loosely coupled with the low-level classes FileLogger and EventLogger.
     * And by doing that we are giving provision to DataExporter class to decide what kind of Logger should be called based on the exception that occurs.*/
    public class ExceptionLogger
    {
        private ILogger _logger;
        public ExceptionLogger(ILogger aLogger)
        {
            this._logger = aLogger;
        }
        public void LogException(Exception aException)
        {
            string strMessage = GetUserReadableMessage(aException);
            this._logger.LogMessage(strMessage);
        }
        private string GetUserReadableMessage(Exception aException)
        {
            string strMessage = string.Empty;
            //code to convert Exception's stack trace and message to user readable format.  

            return strMessage;
        }
    }
}
