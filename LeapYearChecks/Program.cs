using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeapYearChecks
{

    class Program
    {
        public static void Main(string[] args)
        {
           int year = 2016;
           bool check = MyDate.IsLeapYear(year);    

            if(check) 
                Console.WriteLine(year+" is a leap year.");
            else
                Console.WriteLine(year+" is not a leap year.");
        

            Console.WriteLine("Today is " + MyDate.DayInYear() + "th day of its year");
            Console.ReadKey();
        }
    }
}
