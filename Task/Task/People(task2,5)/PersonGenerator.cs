using System;
using System.Collections.Generic;
using System.Text;
namespace Task
{
    class PersonGenerator
    {
        public Person[] Generate(int amount)
        {
            string[] firstName = { "Ivan", "Ruslan", "Petro", "Max", "Dima", "Stas", "Oleg", "Ostap", "Kirill", "Alex" };
            string[] lastName = { "Ivanov", "Ruslanov", "Petrov", "Maxov", "Dimov", "Stasov", "Olegov", "Ostapov", "Kirilov", "Alexov" };
            List<Person> result = new List<Person> { };
            Random random = new Random();
            
            for (int i = 0; i < amount; i++)
            {
                int firstId = new Random().Next(firstName.Length);
                int secondId = new Random().Next(lastName.Length);

                string resultFirstName = firstName[firstId];
                string resultLastName = lastName[secondId];

                int range = 100;
                decimal resultHoureRate = (decimal)random.NextDouble() * range;

                DateTime start = new DateTime(1950, 1, 1);
                int subtract = (DateTime.Today - start).Days;
                DateTime resultRandDate = start.AddDays(random.Next(subtract));

                //For task 2-3

                result.Add(new Person(resultFirstName, resultLastName, resultHoureRate, resultRandDate));

                //For task 5

                //int variety = random.Next(3);
                //if(variety == 0)
                //{
                //    result.Add(new Freelancer(resultFirstName, resultLastName, resultHoureRate, resultRandDate));
                //}
                //if (variety == 1)
                //{
                //    result.Add(new Subcontractor(resultFirstName, resultLastName, resultHoureRate, resultRandDate));
                //}
                //if (variety == 2)
                //{
                //    result.Add(new Employee(resultFirstName, resultLastName, resultHoureRate, resultRandDate));
                //}               
            }
            return result.ToArray();

            // ---------------------Use Faker.NET & NBuilder----------------------------------------------//

            /* var yearsGenerator = new RandomGenerator();
            var people = Builder<Person>.CreateListOfSize(amount)
                .All()
                    .With(c => c.FirstName = Faker.Name.First())
                    .With(c => c.LastName = Faker.Name.Last())
                    .With(c => c.HourRate = Faker.RandomNumber.Next(1,100))
                    .With(c => c.BirthDate = DateTime.Now.AddYears(-yearsGenerator.Next(1950, 2019)))
                .Build();
            return people;*/
        }
    }
}

