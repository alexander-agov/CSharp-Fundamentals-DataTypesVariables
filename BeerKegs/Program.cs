namespace BeerKegs
{
    internal class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            double maxVolume = double.MinValue;
            string perfectModel = string.Empty;
            for (int i = 1; i <= n; i++)
            {
                string model = Console.ReadLine();
                float radius = float.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());
                double volume = Math.PI * Math.Pow(radius, 2) * height;
                if (volume > maxVolume)
                {
                    maxVolume = volume;
                    perfectModel = model;
                }
            }
            Console.WriteLine(perfectModel);
        }
    }
}
