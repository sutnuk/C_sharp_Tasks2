using System;
using System.Collections.Generic;
using System.Text;

namespace Task
{
    class Task1
    {
        private DateTime minDate;
        private DateTime maxDate;
        private  Random rand;

        public DateTime MinDate { get => minDate; set => minDate = value; }
        public DateTime MaxDate { get => maxDate; set => maxDate = value; }
        public Random Rand { get => rand; set => rand = value; }

        public Task1() { }

        public Task1(DateTime minDate, DateTime maxDate)
        {
            this.minDate = minDate;
            this.maxDate = maxDate;
        }

        public IEnumerable<DateTime> ChooseDate(DateTime minDate, DateTime maxDate)
        {
            Rand = new Random();
            int range = (maxDate - minDate).Days;
            yield return minDate.AddDays(Rand.Next(range));
        }
    }
    
}
