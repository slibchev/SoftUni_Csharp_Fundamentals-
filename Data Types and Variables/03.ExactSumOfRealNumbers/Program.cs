
/*
3
1000000000000000000
5
10
 */

namespace _03.ExactSumOfRealNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal n = decimal.Parse(Console.ReadLine());

            decimal sum = 0;
            for (int i = 0; i < n; i++)
            {
                decimal currentInput =  decimal.Parse(Console.ReadLine());
                sum += currentInput;


            }

            Console.WriteLine(sum);
        }
    }
}
