
namespace BasicAssignmentProblems
{
    internal class SwapCase
    {
        public static string  Swapping(double number1, double number2)
        {
            double temp1=number1;
            
            double temp2=number2;
            number2=temp1;
            number1=temp2;
            return ("number1 :" + number1 + " number2 :" + number2);
            
           
        }

    }
}
