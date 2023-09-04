using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_WorkflowEngineExample
{
    class EMailNotificationActivity : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("E Mail Notification Activity");
        }
    }
}
