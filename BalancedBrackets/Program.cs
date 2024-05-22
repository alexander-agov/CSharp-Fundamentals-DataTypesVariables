namespace BalancedBrackets
{
    internal class Program
    {
        static void Main()
        {
            int.TryParse(Console.ReadLine(), out int lines);
            int count = 0;
            string str = "";
            for (int i = 1; i <= lines; i++)
            {
                string line = Console.ReadLine();
                foreach (char c in line)
                {
                    str += c;
                    if (c == ')' || c == '(')
                    {
                        count++;
                    }
                    if (str.Length >= 2)
                    {
                        for (int j = 0; j < str.Length - 1; j++)
                        {
                            if (str[j] == '(' && str[j + 1] == '(')
                            {
                                count--;
                            }
                        }
                    }
                }
            }
            if (count > 0 && count % 2 == 0)
            {
                Console.WriteLine("BALANCED");
            }
            else
            {
                Console.WriteLine("UNBALANCED");
            }
        }
    }
}



