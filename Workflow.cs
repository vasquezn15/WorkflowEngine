using System.Collections.Generic;

namespace WorkflowEngine
{
    public class Workflow : IWorkflowEngine
    {
        private readonly List<ITasks> _tasks;
        public Workflow()
        {
            _tasks = new List<ITasks>();
        }
        public void Add(ITasks tasks)
        {
            _tasks.Add(tasks);
        }

        public void Remove(ITasks tasks)
        {
            _tasks.Remove(tasks);
        }

        public IEnumerable<ITasks> GetTasks()
        {
            return _tasks;
        }
    }
}
