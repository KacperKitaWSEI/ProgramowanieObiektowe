using System;
namespace lab_2_zadanie
{
    public abstract class Person: IThing
    {
        protected string name;
        protected int age;

        public int Age
        {
            get { return age; }
        }

        public string Name
        {
            get { return name; }
        }

        public Person()
        {
        }

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public abstract void Print(string prefix);
    }
}
