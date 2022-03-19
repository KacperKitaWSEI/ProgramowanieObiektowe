using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2
{
    public class Person: IEquatable<Person>
    {
        protected string Name { get; set; }
        protected int Age { get; set; }

        public Person() { }

        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public bool Equals(Person other)
        {
            return Name == other.Name && Age == other.Age;
        }

        public override string ToString() => $"Name: {Name}, Age: {Age}";
    }
}
