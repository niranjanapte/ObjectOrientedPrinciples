using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles.DIP.DIPStatement
{
    class Problem1
    {
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
            private string GetUserReadableMessage(Exception ex)
            {
                string strMessage = string.Empty;
                //code to convert Exception's stack trace and message to user readable format.  

                return strMessage;
            }
        }
        //A client class exports data from many files to a database.
        public class DataExporter
        {
            public void ExportDataFromFile()
            {
                try
                {
                    //code to export data from files to database.  
                }
                catch (Exception ex)
                {
                    new ExceptionLogger().LogIntoFile(ex);
                }
            }
        }

        /* problem in the design
         * We sent our application to the client. But our client wants to store this stack trace in a database if an IO exception occurs. We can implement that too. 
         * Here we need to add one more class that provides the functionality to log the stack trace into the database 
         * and an extra method in ExceptionLogger to interact with our new class to log the stack trace.  Look at Problem2.cs 
         */
    }
}
