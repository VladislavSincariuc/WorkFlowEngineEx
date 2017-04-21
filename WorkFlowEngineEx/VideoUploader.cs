using System;

namespace WorkFlowEngineEx
{
    public class VideoUploader : ITask
    {
        public void Execute()
        {
            Console.WriteLine("Uploading a video");
        }
    }
}