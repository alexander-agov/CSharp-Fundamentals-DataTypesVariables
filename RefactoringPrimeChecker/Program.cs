namespace RefactoringPrimeChecker
{
    internal class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            for (int num = 2; num <= n; num++)
            {
                bool isPrime = true;
                for (int divider = 2; divider < num; divider++)
                {
                    if (num % divider == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                Console.WriteLine("{0} -> {1}", num, isPrime.ToString().ToLower());
            }
        }
    }
}

