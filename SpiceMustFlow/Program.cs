using Microsoft.VisualBasic;
using System.ComponentModel;

namespace SpiceMustFlow
{
    internal class Program
    {
        static void Main()
        {
            int startingYield = int.Parse(Console.ReadLine());
            int count = 0;
            int newLeave = 0;
            while (startingYield >= 100)
            {
                count++;
                newLeave += startingYield - 26;
                startingYield -= 10;
                if (startingYield < 100)
                {
                    newLeave -= 26;
                }
            }
            Console.WriteLine($"{count}\n{(newLeave)}");
        }
    }
}


