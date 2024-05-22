using System.Threading.Tasks;

namespace WaterOverflow
{
    internal class Program
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());
            int sumOfLiters = 0;
            for (int i = 1; i <= num; i++)
            {
                int liters = int.Parse(Console.ReadLine());
                sumOfLiters += liters;
                int tankCapacity = 255;
                if (sumOfLiters > tankCapacity)
                {
                    Console.WriteLine("Insufficient capacity!");
                    sumOfLiters -= liters;
                    continue;
                }
            }
            Console.WriteLine(sumOfLiters);
        }
    }
}

