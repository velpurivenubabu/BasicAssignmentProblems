﻿namespace BasicAssignmentProblems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to BasicProgramming problems Assignment-1!");
            Console.WriteLine("Please choose any one programe from below options");
            Console.WriteLine("1.FlipCoin\n2.LeapYear");
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

            }
        }
    }   
}