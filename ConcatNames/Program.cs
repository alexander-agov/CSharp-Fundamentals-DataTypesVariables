﻿namespace ConcatNames
{
    internal class Program
    {
        static void Main()
        {
            string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();
            string delimiter = Console.ReadLine();
            string result = firstName + delimiter + lastName;
            Console.WriteLine(result);
        }
    }
}
