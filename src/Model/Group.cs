using System;
using System.Collections.Generic;

namespace FitnessStudio.Model
{
    public class Group
    {
        public Group()
        {
            this.Members = new List<Person>();
        }
        public string Name { get; set; }
        public IList<Person> Members { get; private set; }

        public Person Trainer { get; set; }
    }
}