using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SOLID_Principles.ISP.ISPStatement;

namespace SOLID_Principles.ISP
{
    /* Statement
     ISP: No client should be forced to depend on methods it does not use. Many client-specific interfaces are better than one general-purpose interface. */


    public class TeamLead : ILead
    {
        public void AssignTask()
        {
            //Code to assign a task.  
        }
        public void CreateSubTask()
        {
            //Code to create a sub task  
        }
        public void WorkOnTask()
        {
            //Code to implement perform assigned task.  
        }
    }
    public class Manager : ILead
    {
        public void AssignTask()
        {
            //Code to assign a task.  
        }
        public void CreateSubTask()
        {
            //Code to create a sub task.  
        }
        public void WorkOnTask()
        {
            throw new Exception("Manager can't work on Task");
        }
    }

    // Problem in the Design that voilates ISP
    /*
     * Since the Manager can't work on a task and at the same time no one can assign tasks to the Manager, this WorkOnTask() should not be in the Manager class.
     * But we are implementing this class from the ILead interface, we need to provide a concrete Method.
     * Here we are forcing the Manager class to implement a WorkOnTask() method without a purpose. This is wrong. The design violates ISP. 
     * Let's correct the design.
     */
}
