using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCore_Programing
{
    internal class Leap_Year
    {
       
        public void FindLeap()
        {
            Console.WriteLine("Enter a Year");
            int Year = Convert.ToInt32(Console.ReadLine());
            if (Year%4==0)
            {
                Console.WriteLine("It is a Leap Year");
            }
            else if (Year%4!=100)
            {
                Console.WriteLine("It is leap Year");
            }
            else if (Year%400==0)
            {
                Console.WriteLine("It is a leap year");
            }
            else
            {
                Console.WriteLine("it is a not leap year");
            }
        }
    }
}
