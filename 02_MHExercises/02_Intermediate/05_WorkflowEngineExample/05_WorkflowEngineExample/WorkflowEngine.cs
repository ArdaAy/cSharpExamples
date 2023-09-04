using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_WorkflowEngineExample
{
    class WorkflowEngine
    {
        public void Run(Workflow workflow)
        {
            var aList = workflow.aList;
            foreach (var activity in aList)
            {
                activity.Execute();
            }
        }
    }
}
