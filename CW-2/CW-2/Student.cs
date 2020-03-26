using System.Text;

namespace CW_2
{
    class Student : ITaskPerformer
    {
        public delegate void StudentHandler(object obj, TaskEventArgs e);
        public event StudentHandler studentDidTheTask;
        
        public string Name { get; private set; }
        public string Surname { get; private set; }

        public Student(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }

        public string DoTask()
        {
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < 10; i++)
            {
                //97-123 it is lowercase English alphabet
                char c = (char)Randomizer.rnd.Next(97, 123);
                result.Append(c);
            }

            studentDidTheTask?.Invoke(this, new TaskEventArgs(result.ToString()));
            return result.ToString();
        }

    }
}