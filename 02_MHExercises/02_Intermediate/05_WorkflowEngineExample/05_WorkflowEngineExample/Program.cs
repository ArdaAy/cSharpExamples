using System;

namespace _05_WorkflowEngineExample
{
    class Program
    {
        static void Main(string[] args)
        {
            WorkflowEngine workflowEngine = new WorkflowEngine();
            Workflow workflow = new Workflow();

            UploadActivity uploadActivity = new UploadActivity();
            VideoEncodingActivity videoEncodingActivity = new VideoEncodingActivity();
            EMailNotificationActivity eMailNotificationActivity = new EMailNotificationActivity();
            StatusChangerActivity statusChangerActivity = new StatusChangerActivity();

            workflow.aList.Add(uploadActivity);
            workflow.aList.Add(videoEncodingActivity);
            workflow.aList.Add(eMailNotificationActivity);
            workflow.aList.Add(statusChangerActivity);

            workflowEngine.Run(workflow);
        }
    }
}
