namespace FloatingEquality
{
    internal class Program
    {
            static void Main()
            {
                double eps = 0.000001; 

                if (!double.TryParse(Console.ReadLine(), out double number1))
                {
                    Console.WriteLine("Invalid input for the first number.");
                    return;
                }

                if (!double.TryParse(Console.ReadLine(), out double number2))
                {
                    Console.WriteLine("Invalid input for the second number.");
                    return;
                }

                if (Math.Abs(number1 - number2) < eps)
                {
                    Console.WriteLine("True ");
                }
                else
                {
                    Console.WriteLine("False ");
                }
            }
        }
    }

