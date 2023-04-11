

namespace BasicAssignmentProblems
{
    internal class LeapYear
    {
        public static string FindYear(int year)
        {
            bool a =(year%4==0 &&  year%100!=0);// checking weather the given year is divisible by 4,100 or not 
            bool b = (year % 400 == 0);// cheking is given year is divisible by 400 or not
            /* if only b statement true it's a leap year;
             if only a statement true it's a leap year;
             remaining all years are not a leap years */
            if (a || b)
                return year + " is a leap year ";

            else
                return year + " is not a leap year";


        }
    }
}
