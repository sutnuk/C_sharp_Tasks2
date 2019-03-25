using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Task
{
    class NamesProcessor : PersonsProcessor
    {
        public override void Process(IEnumerable<Person> person)
        {
            IEnumerator<Person> enumPerson = person.GetEnumerator();
            enumPerson.MoveNext();
            int countAllPerson = 0;
            
            var names = new SortedList<string, int>();
            do
            {
                if (names.ContainsKey(enumPerson.Current.FirstName))
                    names[enumPerson.Current.FirstName]++;
                else
                {
                    names.Add(enumPerson.Current.FirstName, 1);                    
                }
                countAllPerson++;                
            } while (enumPerson.MoveNext());
            foreach (var res in names)
            {
                Console.WriteLine("Name - " + res.Key + "\nUsed - " + 100*res.Value / countAllPerson + "%\n");
            }
        }
    }
}