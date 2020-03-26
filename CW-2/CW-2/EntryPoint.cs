using System.Collections.Generic;

namespace CW_2
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            List<Student> allStudents = new List<Student>();

            for(int i = 1; i <= 10; i++)
            {
                allStudents.Add(new Student("Name" + i, "Surname" + i));
            }

            Teacher teacher = new Teacher();

            foreach(Student student in allStudents)
            {
                teacher.AddStudentInGroup(student);
            }

            foreach(Student stud in allStudents)
            {
                stud.DoTask();
            }
        }
    }
}