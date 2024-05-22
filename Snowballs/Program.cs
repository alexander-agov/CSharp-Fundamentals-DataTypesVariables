using System.Numerics;

namespace Snowballs
{
    internal class Program
    {
        static void Main()
        {
            int nBalls = int.Parse(Console.ReadLine());
            BigInteger maxValue = new BigInteger(0);
            BigInteger snowballValue = new BigInteger(0);
            int bestSnowballShow = 0;
            int bestSnowballTime = 0;
            int bestSnowballQuality = 0;
            for (int i = 1; i <= nBalls; i++)
            {
                int snowballShow = int.Parse(Console.ReadLine());
                int snowballTime = int.Parse(Console.ReadLine());
                int snowballQuality = int.Parse(Console.ReadLine());
                if (snowballTime != 0)
                {
                    snowballValue = BigInteger.Pow((snowballShow / snowballTime), snowballQuality);
                    if (snowballValue > maxValue)
                    {
                        maxValue = snowballValue;
                        bestSnowballShow = snowballShow;
                        bestSnowballTime = snowballTime;
                        bestSnowballQuality = snowballQuality;
                    }
                }
            }
            Console.WriteLine($"{bestSnowballShow} : {bestSnowballTime} = {maxValue} ({bestSnowballQuality})");
        }
    }
}


