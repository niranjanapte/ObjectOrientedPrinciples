using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles.DIP.DIPSolution.Implementation
{
    public class DataExporter
    {
        public void ExportDataFromFile()
        {
            ExceptionLogger _exceptionLogger;
            try
            {
                //code to export data from files to database.  
            }
            catch (IOException ex)
            {
                _exceptionLogger = new ExceptionLogger(new DbLogger());
                _exceptionLogger.LogException(ex);
            }
            catch (Exception ex)
            {
                _exceptionLogger = new ExceptionLogger(new FileLogger());
                _exceptionLogger.LogException(ex);
            }
        }
    }
    /*Note: 
     But we introduced the dependency here in the DataExporter class's catch blocks.
     * someone must take the responsibility to provide the necessary objects to the ExceptionLogger to make the work done.*/
}
