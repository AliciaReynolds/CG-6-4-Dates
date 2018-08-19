using System;

namespace CG_6_4_Dates
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let's find the difference between your birthday and today.");

            Console.WriteLine("Please input your birthday in the following format - mm/dd/yyyy.");

            DateTime Birthday = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Please input today's date in the following format - mm/dd/yyyy.");
            DateTime Today = DateTime.Parse(Console.ReadLine());

            TimeSpan DateDifference = DateTime.Today.Subtract(Birthday);
            Console.WriteLine(DateDifference.TotalDays);
            Console.ReadLine();


        }
    }
}
