using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicAssignmentProblems
{
    internal class GreatestAmongThreeNumbers
    {
        public static void FindTheGrreatestNumber(int Number1, int Number2, int Number3)
        {
            int gratestNumber=Number1;
            if (Number2>= gratestNumber)
            {
                gratestNumber = Number2;
            }
            if(Number3 >= gratestNumber)
            {
                gratestNumber = Number3;
            }
            Console.Write("gratestNumber: {0}",gratestNumber);
        }
    }
}
