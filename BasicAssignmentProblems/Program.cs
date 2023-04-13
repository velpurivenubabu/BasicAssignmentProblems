namespace BasicAssignmentProblems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to BasicProgramming problems Assignment-1!");
            Console.WriteLine("Please choose any one programe from below options");
            Console.WriteLine("1.FlipCoin\n2.LeapYear\n3.PowersOfTwo\n4.NthHarmonicTerm\n5.primeFactorsOfGivenNumber\n6.QuotientandRemainder\n7.SwapCases\n8.EvenOrOdd\n9.VowelOrConsonant\n10 GratestAmongThreeNumbers");
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
                    case 5:
                    Console.WriteLine("Please Enter The Number witch you want to Find in Prime Factors");
                    int inputNumber = Convert.ToInt32(Console.ReadLine());
                    primeFactors.FindPrimeFactors(inputNumber);
                    break;
                    case 6:
                    Console.WriteLine("Please Enter The Divindend");
                    double divindend = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Please Enter The Divisior");
                    double divisior = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine(QuotientandRemainder.FindQuotientAndRemainder(divindend, divisior));
                    break;
                    case 7:
                    Console.WriteLine("Please Enter The Number1");
                    double number1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Please Enter The Number2");
                    double number2 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine(SwapCase.Swapping(number1,number2));
                    break;
                case 8:
                    Console.WriteLine("Please Enter The Number");
                    int Num = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(EvenOrOdd.FindEvenOrOdd(Num));
                    break;
                case 9:
                    Console.WriteLine("Please Enter any Alphabet");
                    char letter = Convert.ToChar(Console.ReadLine());
                    Console.WriteLine(VowelorConsonant.FindVowelorConsonant(letter));
                    break;
                case 10:
                    Console.WriteLine("Please Enter any Number1");
                    int Number1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Please Enter any Number2");
                    int Number2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Please Enter any Number3");
                    int Number3 = Convert.ToInt32(Console.ReadLine());
                    GreatestAmongThreeNumbers.FindTheGrreatestNumber(Number1, Number2, Number3);
                    break;
                default:
               
                    Console.WriteLine("Enter above Mentioned Optons only");
                    break;

            }
        }
    }   
}