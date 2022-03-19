using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2
{
    class ClassRoom
    {
        public string Name { get; set; }
        Person[] persons;

        public ClassRoom() { }
        public ClassRoom(string name, Person[] persons)
        {
            this.Name = name;
            this.persons = persons;
        }

        public override string ToString() => $"Name: {Name}, Persons: {persons}";
    }
}
