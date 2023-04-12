

using System;

namespace BasicAssignmentProblems
{
    internal class primeFactors
    {
        public static void FindPrimeFactors(int inputNumber)
        {
            bool isPrime = false;/*here i am intilizing one bool variable to check that if that number has at least one prime factor or not if not this will same entire code
                                  other wise it will change its value to false;
                                  */
            for (int i = 2; i<= inputNumber; i++)
            {
                if (inputNumber % i == 0)/*Here first I am finding all factors of Numbers; 
                                           if number divisible by i means i is the factor of that number;
                                           Among all factors I am going to supprate only prime factors;
                                            To find prime factors I know one thing if that factor is not devisible by any number accept by it self and 1 */
                                          
                {
                    int count = 0; // Here i am initilazing acount variable to find the count of factors of all factors of given number;

                    for (int j = 1; j<= i*i; j++)
                    {
                        if (i % j == 0)
                            count++;
                    }
                    if (count == 2)// This condition sagrigate the prime factors from all factors;
                    {

                        Console.WriteLine(i+" ");
                        isPrime = true;// here isPrime variable is chaged to true means the number has prime factors
                    }

                }

            }
            if (!isPrime)// if number  doesn't have any prime factor this conditon executiued
            {
                Console.WriteLine("There is No PrimeFactors For Given Number "+ inputNumber );
            }
        }
    }
}

           