namespace WorkflowEngine
{
    public class WorkflowEngine
    {
        public void Run(IWorkflowEngine workflow)
        {
            foreach (ITasks tasks in workflow.GetTasks())
            {
                tasks.Execute();
            }
        }
    }
}
