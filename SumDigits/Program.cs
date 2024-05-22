namespace SumDigits
{
    internal class Program
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());
            int digit = num;
            int sum = 0;
            while (digit > 0)
            {
                sum += digit % 10;
                digit = digit / 10;
            }
            Console.WriteLine(sum);
        }
    }
}
