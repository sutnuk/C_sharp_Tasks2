using System;
using System.Collections.Generic;
using System.Text;

namespace Task
{
    class AgeStatisticProcessor : PersonsProcessor
    {
        public override void Process(IEnumerable<Person> person)
        {
            IEnumerator<Person> enumPerson = person.GetEnumerator();
            enumPerson.MoveNext();
            Person oldestPerson = enumPerson.Current;
            Person youngestPerson = enumPerson.Current;
            int countId = 0, SummAge = 0;
            do
            {                
                SummAge += enumPerson.Current.Age;
                countId++;
                if (oldestPerson.Age > enumPerson.Current.Age)
                    oldestPerson = enumPerson.Current;              
                if (youngestPerson.Age < enumPerson.Current.Age)
                    youngestPerson = enumPerson.Current;
            } while (enumPerson.MoveNext());
            int averageAge = SummAge / countId;
            Console.WriteLine("Average age: " + averageAge  +
                              "\nOldest person: " + oldestPerson.FullName + "\nAge: " + oldestPerson.Age +
                              "\nYoungestt person: " + youngestPerson.FullName + "\nAge: " + youngestPerson.Age);
        }
    }
}