using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicAssignmentProblems
{
    internal class PowersOf2
    {
        public static string FindPowers(int Power)
        {
            double base2 = 2;
            if (Power < 0) {
                Console.WriteLine("Please Enter The Positive Number");
            }
            else
            {
                for (int i = 0; i <= Power; i++) 
                {
                   double reqPower=Math.Pow(base2,i);
                    Console.WriteLine(reqPower);
                    
                }
            }
            return null;
        }
    }
}
