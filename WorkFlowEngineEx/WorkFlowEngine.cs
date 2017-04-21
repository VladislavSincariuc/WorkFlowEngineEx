namespace WorkFlowEngineEx
{
    public class WorkFlowEngine
    {
        public void Run(IWorkFlow workFlow)
        {
            foreach (ITask I in workFlow.GeTasks())
            {
                I.Execute();
            }
        }
    }
}