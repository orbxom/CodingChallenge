using System;
using System.Collections.Generic;

namespace CodingChallenge.FamilyTree
{
    public class Person
    {
        public Person()
        {
            Descendants = new List<Person>();
        }

        public void AddDescendant(Person person)
        {
            person.parent = this;
            Descendants.Add(person);
        }

        public string Name { get; set; }
        public List<Person> Descendants { get; set; }
        public DateTime Birthday { get; set; }

        public Person parent { get; set; }
    }
}