﻿namespace RefactorVolumeOfPyramid
{
    internal class Program
    {
        static void Main()
        {
           
           double length = double.Parse(Console.ReadLine());
            Console.Write($"Length: ");
            
            double width = double.Parse(Console.ReadLine());
            Console.Write($"Width: ");
            
            double height= double.Parse(Console.ReadLine());
            Console.Write($"Height: ");

            double volume = (length * width / 3) * height;
            Console.WriteLine($"Pyramid Volume: {volume:f2}");
        }
    }
}
