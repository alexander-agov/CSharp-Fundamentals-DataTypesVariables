using System;

namespace RefactorSpecialNumbers
{
    internal class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
           
            for (int i = 1; i <= n; i++)
            {
                int sumOfDigit = 0;
                int digit = i;
             
                while (digit > 0)
                {
                    sumOfDigit += digit % 10;
                    digit = digit / 10;
                }
                if (sumOfDigit == 5 || sumOfDigit == 7 || sumOfDigit == 11)
                {
                    Console.WriteLine($"{i} -> True");
                }
                else
                {
                    Console.WriteLine($"{i} -> False");
                }
            }
        }
    }
}


