/*10.6 (Enhancing Class Date) Modify class Date of Fig. 10.7 to perform error checking on the initializer values for instance variables month, day and year 
       (class Date currently validates only the month and day).
       You’ll need to convert the auto-implemented property Year into instance variable year with an associated Year property.
       Provide method NextDay to increment the day by 1. The Date object should always maintain valid data and throw exceptions when attempts are made to set invalid values.
       Write an app that tests the NextDay method in a loop that displays the date during each iteration of the loop to illustrate that the NextDay method works correctly.
       Test the following cases:
            a) incrementing to the next month and
            b) incrementing to the next year
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Date
{
    private int year;
    private int month;
    private int day;

    public Date(int theDay, int theMonth, int theYear)
    {
        Month = theMonth;
        Year = theYear;
        Day = theDay;
        Console.WriteLine("Date object constructor for date {0}", this);
    }

    public int Year
    {
        get
        {
            return year;
        }
        private set
        {
            if (value > 0 && value <= 2021)
                year = value;
            else
                throw new ArgumentOutOfRangeException(
                "Month", value, "Year must be 0-2021");
        }
    }

    public int Month
    {
        get
        {
            return month;
        }
        private set
        {
            {
                if (value > 0 && value <= 12)
                    month = value;
                else
                    throw new ArgumentOutOfRangeException(
                    "Month", value, "Month must be 1-12");
            }
        }
    }

    public int Day
    {
        get
        {
            return day;
        }
        private set
        {
            int[] daysPerMonth = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            if (value > 0 && value <= daysPerMonth[Month])
                day = value;
            else if (Month == 2 && value == 29 &&
            (Year % 400 == 0 || (Year % 4 == 0 && Year % 100 != 0)))
                day = value;
            else
                throw new ArgumentOutOfRangeException(
                "Day", value, "Day out of range for current month/year");
        }
    }

    public override string ToString()
    {
        return string.Format("{0}/{1}/{2}", Day, Month, Year);
    }

    public void NextDay(Date date)
    {
        int[] daysPerMonth = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        if (day > 0 && day <= daysPerMonth[Month]-1)
            day++;
        else if (Month == 2 && day == 28 &&
        (Year % 400 == 0 || (Year % 4 == 0 && Year % 100 != 0)))
            day++;
        else
        {
            if (month < 12)
            {
                month++;
                day = 1;
            }
            else
            {
                year++;
                month = 1;
                day = 1;
            }
        }
    }
}
