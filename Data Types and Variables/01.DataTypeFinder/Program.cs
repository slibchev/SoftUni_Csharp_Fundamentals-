using System.Runtime.Intrinsics.X86;

namespace _01.DataTypeFinder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
           
            while (input != "END")
            {
                if (Int32.TryParse(input,out _))
                {
                    Console.WriteLine($"{input} is integer type");
                }
                else if (double.TryParse(input, out var value))
                {
                    Console.WriteLine($"{input} is floating point type");
                }
                else if (char.TryParse(input, out _))
                {
                    Console.WriteLine($"{input} is character type");
                }
                else if (bool.TryParse(input, out _))
                {
                    Console.WriteLine($"{input} is boolean type");
                }
                else
                {
                    Console.WriteLine($"{input} is string type");
                }
                input = Console.ReadLine();

            }
        }
    }
}