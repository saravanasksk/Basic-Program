using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArmstrongNumber
{
    /// <summary>
    /// Armstrong Number 153 and 371
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** Armstrong Number ***");
            Console.WriteLine("Enter the Number:");
            int n = Convert.ToInt32(Console.ReadLine());
            int temp, rem, sum = 0;

            temp = n;

            while(temp != 0)
            {
                rem = temp % 10;
                sum = sum + (rem * rem * rem);
                temp = temp / 10;
            }

            if(sum == n)
            {
                Console.WriteLine("Armstrong Number");
            }
            else
            {
                Console.WriteLine("Not a Armstrong Number");
            }

            Console.ReadKey();
        }
    }
}
