using System;
namespace Task
{
    [Serializable]
   public class Person
   {
        private DateTime birthDate;
        private string firstName;
        private string lastName;
        private decimal hourRate;

        public Person()
        { }

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
 
        public DateTime BirthDate { get => this.birthDate; set => this.birthDate = value; }
        public string FirstName { get => this.firstName; set => this.firstName = value; }
        public string LastName { get => this.lastName; set => this.lastName = value; }
        public virtual decimal HourRate
        {
            get => this.hourRate;
            set
            {
                if (Age < 18)
                    this.hourRate = 0;
                else this.hourRate = value;
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
        
        public decimal overallEarnings()
        {
            int today = (DateTime.Today.Year)*12 + DateTime.Today.Month;
            int birthDay = (BirthDate.Year)*12 + BirthDate.Month;
            decimal result = (decimal)(today - birthDay) * 160 * HourRate;
            return result;
        }
   }
}