using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_WorkflowEngineExample
{
    class StatusChangerActivity : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Status Changer Activity");
        }
    }
}
