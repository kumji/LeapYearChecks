using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeapYearChecks
{
        public static class MyDate
        {
            public static bool IsLeapYear(int year)
            {
                if (year % 4 == 0)
                {
                    if (year % 100 == 0)
                    {
                        if (year % 400 == 0)
                            return true; // devided in 4 & 100 & 400
                        else
                            return false; // devided in 4 but also 100
                    }
                    else
                        return true; //devided in 4, but not 100 & 400
                }
                else
                    return false; // not devided in 4
            }

            public static bool IsBefore(DateTime d)
            {
                if (d < DateTime.Today.Date)
                    return true;
                else
                    return true;
            }
             public static bool IsAfter(DateTime d)
            {
                if (d > DateTime.Today.Date)
                    return true;
                else
                    return false;
            }
            public static int DayInYear()
            {
                DateTime thisDay = DateTime.Today;
                int day = thisDay.Day;
                for (int i = 0; i < thisDay.Month; i++)
                {
                    if (i == 2)
                    {
                        if (IsLeapYear(thisDay.Year))
                            day += 29
                        else
                            day += 28;
                    }
                    else if (i == 1 || i == 3 || i == 5 || i == 7 || i == 8 || i == 10 || i == 12)
                    {
                        day += 31;
                    }
                    else
                        day += 30;
                }      
                return day;
        }


        }
}
