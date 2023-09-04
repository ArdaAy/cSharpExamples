using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_WorkflowEngineExample
{
    class Workflow
    {
        public List<IActivity> aList { get; set; }
        public Workflow()
        {
            aList = new List<IActivity>();
        }

    }
}
