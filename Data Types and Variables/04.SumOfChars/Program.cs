

namespace _04.SumOfChars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());

            int totalSum = 0;

            for (int i = 0; i < lines; i++)
            {
                char symbols = char.Parse(Console.ReadLine());
                totalSum += symbols;

            }
            Console.WriteLine($"The sum equals: {totalSum}");
        }
    }
}
