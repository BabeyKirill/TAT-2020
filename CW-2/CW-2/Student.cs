using System.Text;

namespace CW_2
{
    class Student : ITaskPerformer
    {
        public delegate void EventHandler(object obj, TaskEventArgs e);
        public event EventHandler StudentDidTheTask;

        public string Name { get; private set; }
        public string Surname { get; private set; }

        public Student(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }

        public void DoTask()
        {
            const int resultLength = 10;
            const int lowerCaseAlphabetStart = 97;
            const int lowerCaseAlphabetEnd = 122;
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < resultLength; i++)
            {
                char c = (char)Randomizer.rnd.Next(lowerCaseAlphabetStart, lowerCaseAlphabetEnd + 1);
                result.Append(c);
            }

            StudentDidTheTask?.Invoke(this, new TaskEventArgs(result.ToString()));
        }
    }
}