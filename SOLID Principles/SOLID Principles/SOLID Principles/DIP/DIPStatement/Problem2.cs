using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles.DIP.DIPStatement
{
    class Problem2
    {
        public class DbLogger
        {
            public void LogMessage(string aMessage)
            {
                //Code to write message in database.  
            }
        }
        public class FileLogger
        {
            public void LogMessage(string aStackTrace)
            {
                //code to log stack trace into a file.  
            }
        }
        public class ExceptionLogger
        {
            public void LogIntoFile(Exception aException)
            {
                FileLogger objFileLogger = new FileLogger();
                objFileLogger.LogMessage(GetUserReadableMessage(aException));
            }
            public void LogIntoDataBase(Exception aException)
            {
                DbLogger objDbLogger = new DbLogger();
                objDbLogger.LogMessage(GetUserReadableMessage(aException));
            }
            private string GetUserReadableMessage(Exception ex)
            {
                string strMessage = string.Empty;
                //code to convert Exception's stack trace and message to user readable format.  

                return strMessage;
            }
        }
        public class DataExporter
        {
            public void ExportDataFromFile()
            {
                try
                {
                    //code to export data from files to database.  
                }
                catch (IOException ex)
                {
                    new ExceptionLogger().LogIntoDataBase(ex);
                }
                catch (Exception ex)
                {
                    new ExceptionLogger().LogIntoFile(ex);
                }
            }
        }

        /* Problem that voilates DIP principle
         * whenever the client wants to introduce a new logger, we need to alter ExceptionLogger by adding a new method. 
         * If we continue doing this after some time then we will see a fat ExceptionLogger class with a large set of methods that provide the functionality to log a message into various targets. Why does this issue occur? 
         * Because ExceptionLogger directly contacts the low-level classes FileLogger and and DbLogger to log the exception. This voilates DIP.
         * Solution : 
         * We need to alter the design so that this ExceptionLogger class can be loosely coupled with those class.
         * To do that we need to introduce an abstraction between them, so that ExcetpionLogger can contact the abstraction 
         * to log the exception instead of depending on the low-level classes directly. 
         */
    }
}
