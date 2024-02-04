
namespace _06.StrongNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputNumber = Console.ReadLine();
            int inputCopy = int.Parse(inputNumber);
            int factorialSum = 0;

            for (int i = 0; i < inputNumber.Length; i++)
            {
                int digit = inputNumber[i]-'0';

                int result = 1;

                if (digit == 0)
                {
                    result = 1;
                   
                }
                for (int j = digit; j >0; j--)
                {
                    result *= j;
                }

                factorialSum += result;

               
            }

            Console.WriteLine(factorialSum ==inputCopy ? $"yes": $"no");


        }
    }
}
