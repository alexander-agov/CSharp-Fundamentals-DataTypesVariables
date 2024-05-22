namespace DecryptingMessages
{
    internal class Program
    {
        static void Main()
        {
            int key = int.Parse(Console.ReadLine());
            int numLines = int.Parse(Console.ReadLine());
            string str = "";
            for (int i = 1; i <= numLines; i++) 
            {
                char.TryParse(Console.ReadLine(), out char letter);
               int  code = key + (int)letter;
                str += (char)code;
            }
            Console.WriteLine(str);
        }
    }
}
