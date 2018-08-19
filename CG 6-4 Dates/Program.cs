using System;

namespace CG_6_4_Dates
{
    class Program
    {
        static void Main(string[] args)
        {
            //This code asks for the user to input a date
            Console.WriteLine("Let's find the difference between your birthday and today.");
            Console.WriteLine("Please input your birthday in the following format - mm/dd/yyyy.");

            //This code takes the inputted data and assigns it to a variable
            DateTime Birthday = DateTime.Parse(Console.ReadLine());

            //This code asks the user to input today's date, then stores that info into a variable
            Console.WriteLine("Please input today's date in the following format - mm/dd/yyyy.");
            DateTime Today = DateTime.Parse(Console.ReadLine());

            //This code takes the two dates (today's date and the birthday) that the user
            //provides, subtracts them, and then gives the difference in days.
            TimeSpan DateDifference = DateTime.Today.Subtract(Birthday);
            Console.WriteLine(DateDifference.TotalDays + " days");
            Console.ReadLine();


        }
    }
}
