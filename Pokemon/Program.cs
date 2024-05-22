namespace Pokemon
{
    internal class Program
    {
        static void Main()
        {
            int pokePower = int.Parse(Console.ReadLine());
            int distance = int.Parse(Console.ReadLine());
            int exhaustionFactor = int.Parse(Console.ReadLine());
            int count = 0;
            double pokeP = pokePower;
            while (pokePower >= distance)
            {
                pokePower -= distance;
                
                count++;
                if (pokePower < distance)
                {
                    Console.WriteLine($"{pokePower}\n{count}");
                    return;
                }
                if (pokeP / 2.0 == pokePower && exhaustionFactor != 0)
                {
                   pokePower= pokePower / exhaustionFactor;
                    
                }
            }
            Console.WriteLine($"{pokePower}\n{count}");
        }
    }
}
    



