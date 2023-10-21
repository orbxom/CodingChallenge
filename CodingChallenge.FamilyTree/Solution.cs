using System;
using System.Collections.Generic;
using System.Linq;

namespace CodingChallenge.FamilyTree
{
    public class Solution
    {
        public string GetBirthMonth(Person person, string descendantName)
        {
            var queue = new Queue<Person>();
            queue.Enqueue(person);

            Person? descendant = null;
            var processed = 0;

            var names = new List<string>();

            while (queue.Count > 0)
            {
                var currentPerson = queue.Dequeue();
                names.Add(currentPerson.Name);
                processed++;
                currentPerson.Descendants.ForEach(x => queue.Enqueue(x));

                if (currentPerson.Name == descendantName)
                {
                    descendant = currentPerson;
                }
            }

            Console.WriteLine($"Processed: {processed}");
            names = names.OrderBy(x => x).ToList();

            if (descendant != null)
            {
                return descendant.Birthday.ToString("MMMM");
            }
            else
            {
                return "";
            }
        }
    }
}