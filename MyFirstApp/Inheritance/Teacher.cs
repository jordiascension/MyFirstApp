using System;

namespace MyFirstApp.Inheritance
{
    public class Teacher : Person
    {
        public string Subject { get; set; }
        public float Salary { get; set; }

        public Teacher()
        {

        }

        public Teacher(string subject, float salary,
            string name, string surname
            ) : base(name, surname)
        {
            Subject = subject;
            Salary = salary;
        }

        public override bool Equals(object obj)
        {
            return obj is Teacher teacher &&
                   base.Equals(obj) &&
                   Guid.Equals(teacher.Guid) &&
                   Name == teacher.Name &&
                   Surname == teacher.Surname &&
                   Subject == teacher.Subject &&
                   Salary == teacher.Salary;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(base.GetHashCode(), Guid, Name, Surname, Subject, Salary);
        }
    }
}
