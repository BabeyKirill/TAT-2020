namespace CW_2
{
    struct TaskResults
    {
        public string Name;
        public string Surname;
        public string TaskAnswer;
        public int Grade;

        public TaskResults(string name, string surname, string taskAnswer, int grade)
        {
            Name = name;
            Surname = surname;
            TaskAnswer = taskAnswer;
            Grade = grade;
        }
    }
}