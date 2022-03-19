using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2
{
    class Student: Person
    {
        protected List<Task> tasks = new List<Task>();
        protected string Group { get; set; }

        public Student(string name, int age, string group)
        {
            this.Name = name;
            this.Age = age;
            this.Group = group;
        }

        public Student(string name, int age, string group, List<Task> tasks)
        {
            this.Name = name;
            this.Age = age;
            this.Group = group;
            this.tasks = tasks;
        }

        public void AddTask(string taskName, TaskStatus taskStatus)
        {
            this.tasks.Add(new Task(taskName, taskStatus));
        }

        public void RemoveTask(int index)
        {
            this.tasks.RemoveAt(index);
        }

        public void UpdateTask(int index, TaskStatus taskStatus)
        {
            this.tasks
        }
    }

    class Task: IEquatable<Task>
    {
        public string Name { get; set; }
        public TaskStatus Status { get; set; }

        public Task(string name, TaskStatus status)
        {
            Name = name;
            Status = status;
        }

        public bool Equals(Task other)
        {
            return Name == other.Name && Status == other.Status;
        }

        public override string ToString() => $"Name: {Name}, Status: {Status}";
    }

    enum TaskStatus
    {
        Waiting,
        Progress,
        Done,
        Rejected
    }

    class Teacher: Person
    {
        public Teacher(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
    }
}


