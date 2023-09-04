using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_WorkflowEngineExample
{
    class UploadActivity : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Video Uploading Activity");
        }
    }
}
