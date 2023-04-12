using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicAssignmentProblems
{
    internal class HarmonicSeries
    {
        public static string FindTotal(int HarmonicNumber)
        {
           
            double Total = 0;
            if (HarmonicNumber <= 0)
            {
                Console.WriteLine("Please Enter Geter Than Zero");

            }
            else
            {
                for (int i = 1; i <=HarmonicNumber; i++)
                {
                    double term = 1 /(float)i;
                    Total += term;
                    
                }   
            }
            return Total.ToString();
        }
    }
}
