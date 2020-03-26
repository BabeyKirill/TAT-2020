using System;
using System.Collections.Generic;

namespace CW_2
{
    class Teacher
    {
        public List<Student> Group { get; private set; }
        public List<Student> ListOfReadyStudents { get; private set; }
        public List<TaskResults> TaskResults { get; private set; }

        public Teacher()
        {
            Group = new List<Student>();
            ListOfReadyStudents = new List<Student>();
            TaskResults = new List<TaskResults>();
        }

        public void AddStudentInGroup(Student student)
        {
            if (Group.Contains(student) == false)
            {
                Group.Add(student);
                student.StudentDidTheTask += AcceptTheWork;
            }
        }

        public void AcceptTheWork(object sender, TaskEventArgs e)
        {
            if (ListOfReadyStudents.Contains((Student)sender) == false)
            {
                int grade = ToGradeTheAnswer(e.Answer);

                ListOfReadyStudents.Add((Student)sender);
                TaskResults.Add(new TaskResults(((Student)sender).Name, ((Student)sender).Surname, e.Answer, grade));

                if (Group.Count == TaskResults.Count)
                {
                    PrintAllResults();
                }
            }          
        }

        public int ToGradeTheAnswer(string answer)
        {
            const int SizeOfAlphabet = 25;
            const int CodeOfFirstLetter = 96;
            const int MaxGrade = 10;
            double grade = 0;

            foreach (char c in answer)
            {
                grade += (int)c - CodeOfFirstLetter;
            }

            grade = grade / SizeOfAlphabet;

            for (int i = 0; i <= MaxGrade; i++)
            {
                if(grade >= i && grade <= i + 0.5)
                {
                    grade = i;
                    break;
                }
                if (grade >= i + 0.5 && grade <= i)
                {
                    grade = i + 1;
                    break;
                }
            }

            return (int)grade;
        }

        public void PrintAllResults()
        {
            foreach (TaskResults result in TaskResults)
            {
                Console.WriteLine($"{result.Name} {result.Surname} Answer: {result.TaskAnswer}. Grade: {result.Grade}");
            }
        }
    }
}