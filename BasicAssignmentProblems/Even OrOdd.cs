using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicAssignmentProblems
{
    internal class EvenOrOdd
    {
        public static string FindEvenOrOdd(int Num)
        {
            if (Num % 2 == 0)
                return(Num+" is Even Number");
            else
                return (Num + " is Odd Number");

        }
    }
}
