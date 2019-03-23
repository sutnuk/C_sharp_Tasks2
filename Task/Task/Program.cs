using System;

namespace Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Task1 task1 = new Task1();
            DateTime first = new DateTime(2009, 1, 1);
            DateTime second = new DateTime(2010, 1, 1);
            int j = 0;
            foreach (DateTime i in task1.ChooseDate(first, second))
            {
                Console.WriteLine(i);
                
            }
            Console.ReadKey();
        }
    }
}
