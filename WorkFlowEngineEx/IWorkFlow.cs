using System.Collections.Generic;

namespace WorkFlowEngineEx
{
    public interface IWorkFlow
    {
        void Add(ITask task);
        void Remove(ITask task);
        IEnumerable<ITask> GeTasks();
    }
}