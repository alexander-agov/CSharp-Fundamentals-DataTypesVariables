﻿namespace ConvertMetersToKilimeters
{
    internal class Program
    {
        static void Main()
        {
            int meters = int.Parse(Console.ReadLine());
            float kilometers = meters / 1000.0f;
            Console.WriteLine($"{kilometers:f2}");
        }
    }
}

