using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SOLID_Principles.ISP.ISPSolutionToProblem.Interfaces;

namespace SOLID_Principles.ISP.ISPSolutionToProblem.Implementation
{
    //Note: TeamLead can manage tasks and can work on them if needed. Then the TeamLead class should implement both of the IProgrammer and ILead interfaces.

    public class TeamLead : IProgrammer, ILead
    {
        public void AssignTask()
        {
            //Code to assign a Task  
        }
        public void CreateSubTask()
        {
            //Code to create a sub task from a task.  
        }
        public void WorkOnTask()
        {
            //code to implement to work on the Task.  
        }
    }
}
