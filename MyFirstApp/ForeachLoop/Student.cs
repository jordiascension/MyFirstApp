using System;

using CsvHelper;

namespace MyFirstApp.ForeachLoop
{
    public class Student
    {
        public Guid Guid { get; set; }
        public int StudentId { get; set; }
        public String Name { get; set; }
        public String Surname { get; set; }
        public int Age { get; set; }

        // Static variable that must be initialized at run time.
        // static means shared
        public static int STUDENT_COUNTER;

        // Static constructor is called at most one time, before any
        // instance constructor is invoked or member is accessed.
        // is single thread and you can use it to create a singleton
        static Student()
        {
            STUDENT_COUNTER = 0;
        }

        public Student()
        {
            STUDENT_COUNTER += 1;
            Guid = Guid.NewGuid();
        }

        public Student(int studentId, string name, string surname, int age) :
            this()
        {
            StudentId = studentId;
            Name = name;
            Surname = surname;
            Age = age;
        }

        public override bool Equals(object obj)
        {
            return obj is Student student &&
                   StudentId == student.StudentId &&
                   Name == student.Name &&
                   Surname == student.Surname &&
                   Age == student.Age;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(StudentId, Name, Surname, Age);
        }
    }
}