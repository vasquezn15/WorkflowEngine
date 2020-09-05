using System.Collections.Generic;

namespace WorkflowEngine
{
    public interface IWorkflowEngine
    {
        public void Add(ITasks tasks);
        public void Remove(ITasks tasks);
        IEnumerable<ITasks> GetTasks();
    }
}