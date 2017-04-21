using System;

namespace WorkFlowEngineEx
{
    public class ChandeStatus : ITask
    {
        public void Execute()
        {
            Console.WriteLine("changing status...");
        }
    }
}