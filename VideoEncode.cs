using System;

namespace WorkflowEngine
{
    public class VideoEncode : ITasks
    {
        public void Execute()
        {
            Console.WriteLine("Sending video encoding...");
        }
    }
}
