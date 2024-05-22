﻿namespace DataTypeFinder
{
    internal class Program
    {
        static void Main()
        {
           string input = Console.ReadLine();
            while (input != "END")
            {
                if (int.TryParse(input, out _))
                {
                    Console.WriteLine($"{input} is integer type");
                    input = Console.ReadLine();
                }
                else if (float.TryParse(input, out _))
                {
                    Console.WriteLine($"{input} is floating point type");
                    input = Console.ReadLine();
                }
                else if (bool.TryParse(input, out _))
                {
                    Console.WriteLine($"{input} is boolean type");
                    input = Console.ReadLine();
                }
                else if (char.TryParse(input, out _))
                {
                    Console.WriteLine($"{input} is character type");
                    input = Console.ReadLine();
                }
                else
                {
                    Console.WriteLine($"{input} is string type");
                    input = Console.ReadLine();
                }
            }
        }
    }
}
