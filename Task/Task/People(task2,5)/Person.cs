using FizzWare.NBuilder;
using System;
using System.Collections.Generic;
using System.Text;
namespace Task
{
    class Person
    {
        public Person() { }

        public Person(decimal hourRate)
        {
            this.hourRate = hourRate;
        }

        public Person(string firstName, string lastName, decimal hourRate, DateTime birthDate)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.hourRate = hourRate;
            this.birthDate = birthDate;
        }

        private DateTime birthDate;
        private string firstName;
        private string lastName;
        private decimal hourRate;
 

        public DateTime BirthDate { get => birthDate; set => birthDate = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public virtual decimal HourRate
        {
            get => hourRate;
            set
            {
                if (Age < 18)
                    hourRate = 0;
                else hourRate = value;
            }
        }
        public int Age
        {
            get
            {
                DateTime currentDate = new DateTime();
                currentDate = DateTime.Today;
                return currentDate.Subtract(BirthDate).Days / 365;
            }
        }
        public string FullName { get
            {
                return FirstName + " " + LastName;
            }
        }

        public string GetPersonInfo()
        {
            string result;
            result = "Full name - " + FullName + "\nAge - " + Age;
            if (Age > 18)
                return result += "\nPotentional salary - " + HourRate * 160;
            else
                return result += "\nPotentional salary - " + HourRate * 0 + " (Because person is younger than 18 years)";
        }
        //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
        public decimal overallEarnings()
        {
            int today = (DateTime.Today.Year)*12 + DateTime.Today.Month;
            int birthDay = (BirthDate.Year)*12 + BirthDate.Month;
            decimal result = (decimal)(today - birthDay) * 160 * HourRate;
            return result;
        }
    }
}