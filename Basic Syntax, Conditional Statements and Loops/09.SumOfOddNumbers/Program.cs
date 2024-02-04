namespace _09.SumOfOddNumbers
{
    internal class Program
    {
        static void Main()
        {
            int input = int.Parse(Console.ReadLine());

            var sum = 0;
            int cycleCounter = 0;
            int startingNum = 1;

            while (true)
            {

                if (startingNum % 2 != 0)
                {
                    Console.WriteLine(startingNum);
                    sum += startingNum;
                    cycleCounter++;
                    startingNum += 2;

                }

                if (cycleCounter == input)
                {
                    break;
                }
            }

            Console.WriteLine($"Sum: {sum}");
        }
    }
}
