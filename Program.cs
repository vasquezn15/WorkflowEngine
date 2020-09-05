using System;

namespace WorkflowEngine
{
    class Program
    {
        public class changeVideoStatus : ITasks
        {
            public void Execute()
            {
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            Workflow workflow = new Workflow();
            workflow.Add(new SendEmail());
            workflow.Add(new VideoEncode());

            WorkflowEngine engine = new WorkflowEngine();
            engine.Run(workflow);
        }
    }
}
