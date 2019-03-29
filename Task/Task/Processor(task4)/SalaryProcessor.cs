using System;
using System.Collections.Generic;
using System.Text;

namespace Task
{
    class SalaryProcessor : PersonsProcessor
    {
        public override void Process(IEnumerable<Person> person)
        {           
            IEnumerator<Person> enumPerson = person.GetEnumerator();
            enumPerson.MoveNext();
            Person highlyPayedPerson = enumPerson.Current;
            do
            {
                if (enumPerson.Current.Age > 18)
                {                                      
                    Console.WriteLine("Name:" + enumPerson.Current.FullName  + "\nAge:" + enumPerson.Current.Age +
                                      "\nOverall Earnings: " + enumPerson.Current.overallEarnings());
                    if (highlyPayedPerson.overallEarnings() < enumPerson.Current.overallEarnings())
                        highlyPayedPerson = enumPerson.Current;
                }                 
            } while (enumPerson.MoveNext());
            Console.WriteLine("\n\nHighly Payed Person: " +
                              "\nName: " + highlyPayedPerson.FullName +
                              "\nAge: " + highlyPayedPerson.Age +
                              "\nOverall Earnings: " + highlyPayedPerson.overallEarnings());
        }
    }
}