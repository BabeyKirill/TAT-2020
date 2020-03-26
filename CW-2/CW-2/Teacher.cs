using System;
using System.Collections.Generic;

namespace CW_2
{
    class Teacher
    {
        public List<Student> Group { get; private set; }
        public List<Student> ListOfReadyStudents { get; private set; }
        public List<string> TaskResults { get; private set; }

        public Teacher()
        {
            Group = new List<Student>();
            ListOfReadyStudents = new List<Student>();
            TaskResults = new List<string>();
        }

        public void AddStudentToGroup(Student student)
        {
            if (Group.Contains(student) == false)
            {
                Group.Add(student);
                student.studentDidTheTask += AcceptTheWork;
            }
        }

        public void AcceptTheWork(object sender, TaskEventArgs e)
        {
            if (ListOfReadyStudents.Contains((Student)sender) == false)
            {
                ListOfReadyStudents.Add((Student)sender);
                TaskResults.Add(e.TaskResult);

                foreach (Student student in Group)
                {
                    if (ListOfReadyStudents.Contains(student) == false)
                    {
                        return;
                    }
                }

                ShowAllResults();
            }          
        }

        public void ShowAllResults()
        {
            for (int i = 0; i < ListOfReadyStudents.Count; i++)
            {
                Console.WriteLine($"{ListOfReadyStudents[i].Name} {ListOfReadyStudents[i].Surname}: {TaskResults[i]}");
            }
        }
    }
}