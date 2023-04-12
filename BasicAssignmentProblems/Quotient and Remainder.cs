
namespace BasicAssignmentProblems
{
    internal class QuotientandRemainder
    {
        public static string FindQuotientAndRemainder(double divindend, double divisior)
        {
            double quotient = (divindend / divisior);
            double reminder= (divindend % divisior);
            return ("Quotient is "+ quotient + " and Reminder is "+reminder);
        }
    }
}

