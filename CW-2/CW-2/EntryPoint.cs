using System.Collections.Generic;

namespace CW_2
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            List<Student> allStudents = new List<Student>();
            Student s1 = new Student("Name1", "Surname1");         
            Student s2 = new Student("Name2", "Surname2");
            Student s3 = new Student("Name3", "Surname3");
            Student s4 = new Student("Name4", "Surname4");
            Student s5 = new Student("Name5", "Surname5");
            Student s6 = new Student("Name6", "Surname6");
            Student s7 = new Student("Name7", "Surname7");
            Student s8 = new Student("Name8", "Surname8");
            Student s9 = new Student("Name9", "Surname9");
            Student s10 = new Student("Name10", "Surname10");

            allStudents.Add(s1);
            allStudents.Add(s2);
            allStudents.Add(s3);
            allStudents.Add(s4);
            allStudents.Add(s5);
            allStudents.Add(s6);
            allStudents.Add(s7);
            allStudents.Add(s8);
            allStudents.Add(s9);
            allStudents.Add(s10);

            allStudents.Add(s5);
            allStudents.Add(s3);

            Teacher tch = new Teacher();
            tch.AddStudentToGroup(s1);
            tch.AddStudentToGroup(s2);
            tch.AddStudentToGroup(s3);
            tch.AddStudentToGroup(s4);
            tch.AddStudentToGroup(s5);
            tch.AddStudentToGroup(s6);
            tch.AddStudentToGroup(s7);
            tch.AddStudentToGroup(s8);
            tch.AddStudentToGroup(s9);
            tch.AddStudentToGroup(s10);

            foreach(Student stud in allStudents)
            {
                stud.DoTask();
            }

            s6.DoTask();
            s6.DoTask();
            s6.DoTask();
            s6.DoTask();
        }
    }
}
