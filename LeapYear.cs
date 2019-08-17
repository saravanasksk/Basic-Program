using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeapYear
{
    /// <summary>
    /// Leap year is 366 days 
    /// Normal year is 365 days
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** Leap Year ***");
            Console.WriteLine("Enter the Year:");
            int year = Convert.ToInt32(Console.ReadLine());

            int rem_4 = year % 4;
            int rem_100 = year % 100;
            int rem_400 = year % 400;

            if((rem_4 == 0 && rem_100 != 0) || rem_400 == 0)
            {
                Console.WriteLine("Leap Year");
            }
            else
            {
                Console.WriteLine("Not a Leap Year");
            }

            Console.ReadKey();
        }
    }
}
