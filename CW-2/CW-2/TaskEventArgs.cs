namespace CW_2
{
    class TaskEventArgs
    {
        public string TaskResult { get; }

        public TaskEventArgs(string taskResult)
        {
            this.TaskResult = taskResult;
        }
    }
}
