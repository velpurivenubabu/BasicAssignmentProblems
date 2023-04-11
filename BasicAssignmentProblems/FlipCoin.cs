
namespace BasicAssignmentProblems
{
    class FlipCoin
    {
        public static string FindPercentage(int number)
        {
            double HeadTotal = 0;
            double TailTotal = 0;
            Random random = new Random();
            for (int i=0; i<number; i++)
            {
                
                double reqNumber = random.NextDouble();
                //double  = (coinSide * 0.1);
                if (reqNumber < 0.5)
                {
                    HeadTotal++;

                }
                else
                {
                    TailTotal++;
                }
                
            }
            Console.WriteLine(TailTotal);
            Console.WriteLine(HeadTotal);
            double HeadsPersentage =((HeadTotal /number)*100);
            double TailssPersentage =((TailTotal /number)*100);
            
            return "Head Total Persentage is : " + HeadsPersentage+" %" + " Tail Total persentage is : " + TailssPersentage + " %";


        }
    }
}
