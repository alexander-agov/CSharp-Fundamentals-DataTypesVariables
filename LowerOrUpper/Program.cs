namespace LowerOrUpper
{
    internal class Program
    {
        static void Main()
        {
            char letter = char.Parse(Console.ReadLine());
            if (letter == char.ToUpper(letter))
            {
                Console.WriteLine("upper-case");
            } else 
            {
                Console.WriteLine("lower-case");
             }
        }
    }
}
