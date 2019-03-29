using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
namespace Task
{    class Program
    {
        static void Main(string[] args)
        {
            /////////////////   Task1   /////////////////    

            //RandomDate date = new RandomDate();
            //DateTime first = new DateTime(2009, 1, 1);
            //DateTime second = new DateTime(2010, 1, 1);       
            //foreach (DateTime i in date.ChooseDate(first, second))
            //    Console.WriteLine(i);

            /////////////////   Task2-3   /////////////////

            //Person[] people = new PersonGenerator().Generate(10);
            //foreach (Person person in people)
            //    Console.WriteLine(person.GetPersonInfo());

            /////////////////   Task4  /////////////////

            //Person[] people = new PersonGenerator().Generate(10);
            //SalaryProcessor salary = new SalaryProcessor();
            //salary.Process(people);

            //Person[] people = new PersonGenerator().Generate(10);
            //AgeStatisticProcessor age = new AgeStatisticProcessor();
            //age.Process(people);

            //Person[] people = new PersonGenerator().Generate(10);
            //NamesProcessor names = new NamesProcessor();
            //names.Process(people);

            /////////////////   Task5  /////////////////

            //Person[] people = new PersonGenerator().Generate(10);
            //foreach (Person person in people)
            //    Console.WriteLine(person.GetPersonInfo());

            /////////////////  Serializable  /////////////////

            Person[] people = new PersonGenerator().Generate(10);            
            XmlSerializer serializable = new XmlSerializer(typeof(Person[]));
            using (FileStream file = new FileStream("people.xml", FileMode.OpenOrCreate))
            {
                serializable.Serialize(file, people);
                Console.WriteLine("Serializable done");
            }

            using (FileStream file = new FileStream("people.xml", FileMode.OpenOrCreate))
            {
                Person[] newPersons = (Person[])serializable.Deserialize(file);

                Console.WriteLine("Deserializable done");
                foreach (Person person in newPersons)
                {
                    Console.WriteLine("Имя: {0} --- Возраст: {1}", person.FullName, person.Age);
                }
            }
            Console.ReadKey();
        }
    }
}