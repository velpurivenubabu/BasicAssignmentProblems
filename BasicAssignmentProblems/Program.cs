namespace BasicAssignmentProblems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to BasicProgramming problems Assignment-1!");
            Console.WriteLine("Please choose any one programe from below options");
            Console.WriteLine("1.FlipCoin\n2.LeapYear\n3.PowersOfTwo\n4.NthHarmonicTerm");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Console.WriteLine("Please Enter The Number How many times you want to flip the coin");
                    int number = Convert.ToInt32(Console.ReadLine());
                    string persentage=FlipCoin.FindPercentage(number);
                    Console.WriteLine(persentage);   
                    break;
                case 2:
                    Console.WriteLine("Please Enter The Year Number which sholud have four digits");
                    int year = Convert.ToInt32(Console.ReadLine());
                    string YearType = LeapYear.FindYear(year);
                    Console.WriteLine(YearType);
                    break;
                    case 3:
                    Console.WriteLine("Please Enter The Maximum power of 2 wiich you want to find");
                    int Power = Convert.ToInt32(Console.ReadLine());
                    string PowersOfTwo = PowersOf2.FindPowers(Power);
                    //Console.WriteLine(PowersOfTwo);
                    break;
                    case 4:
                    Console.WriteLine("Please Enter The Number witch you want to Find in Harmonic Series");
                    int HarmonicNumber = Convert.ToInt32(Console.ReadLine());
                    string reqTotal = HarmonicSeries.FindTotal(HarmonicNumber);
                    Console.WriteLine(reqTotal);
                    break;

            }
        }
    }   
}