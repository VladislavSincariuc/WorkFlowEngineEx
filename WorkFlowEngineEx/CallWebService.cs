using System;

namespace WorkFlowEngineEx
{
    public class CallWebService : ITask
    {
        public void Execute()
        {
            Console.WriteLine("Calling web service...");
        }
    }
}