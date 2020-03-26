namespace CW_2
{
    class TaskEventArgs
    {
        public string Answer { get; }

        public TaskEventArgs(string answer)
        {
            this.Answer = answer;
        }
    }
}