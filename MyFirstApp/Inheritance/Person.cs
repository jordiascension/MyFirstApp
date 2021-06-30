using System;

namespace MyFirstApp.Inheritance
{
    public class Person
    {
        public Guid Guid { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        public Person()
        {
            Guid = Guid.NewGuid();
        }

        public Person(string name, string surname) : this()
        {

            Name = name;
            Surname = surname;
        }

        public override bool Equals(object obj)
        {
            return obj is Person person &&
                   Guid.Equals(person.Guid) &&
                   Name == person.Name &&
                   Surname == person.Surname;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Guid, Name, Surname);
        }
    }
}
