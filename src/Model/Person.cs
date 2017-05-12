using System;

namespace FitnessStudio.Model
{
    public class Person
    {
        public Person() { }

        public Person(string name)
        {
            this.Name = name;
        }
        public string Name { get; set; }
    }
}