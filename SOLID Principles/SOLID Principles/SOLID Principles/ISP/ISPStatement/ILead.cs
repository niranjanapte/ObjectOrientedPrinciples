using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles.ISP.ISPStatement
{
    public interface ILead
    {
        void CreateSubTask();
        void AssginTask();
        void WorkOnTask();
    }
}
