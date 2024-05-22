namespace ExactSumOfRealNumbers
{
    internal class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());           //1000000000000000015
            decimal sum = 0;
            for (int i = 0; i < n; i++)
                sum += decimal.Parse(Console.ReadLine());
            Console.WriteLine(sum);
        }
    }
}

