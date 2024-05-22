namespace Elevator
{
    internal class Program
    {
        static void Main()
        {
            int people = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());
            if (people <= capacity)
            {
                Console.WriteLine("1");
            }
            else if (people % capacity == 0)
            {
                int courses = 0;
                courses = people / capacity;
                Console.WriteLine($"{courses}");
            }
            else if (people % capacity <= capacity)
            {
                int courses = 0;
                courses = (int)Math.Ceiling((double)people / capacity);
                Console.WriteLine($"{courses}");
            }
        }
    }
}

