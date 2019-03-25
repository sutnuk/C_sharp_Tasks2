using System;
using System.Collections.Generic;
using System.Text;

namespace Task
{
    class Subcontractor : Person
    {
        public Subcontractor(string firstName, string lastName, decimal hourRate, DateTime birthDate) : base(firstName, lastName, hourRate, birthDate)
        {
            this.FirstName = firstName;
            this.LastName = lastName + " - subcontractor";
            this.HourRate = hourRate;
            this.BirthDate = birthDate;
        }
        public override decimal HourRate
        {
            get
            {
                return base.HourRate * (decimal)2.2;
            }
        }
    }
}
