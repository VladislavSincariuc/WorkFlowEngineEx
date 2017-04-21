using System;

namespace WorkFlowEngineEx
{
    public class SendEmail : ITask
    {
        public void Execute()
        {
            Console.WriteLine("Sending an email...");
        }
    }
}