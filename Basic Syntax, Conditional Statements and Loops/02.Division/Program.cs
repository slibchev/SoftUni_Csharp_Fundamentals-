namespace _02.Division
{
    internal class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int highestDivider = 2;
            bool isDividable = false;
            for (int i = 2; i <= 10; i++)
            {

                if (i == 4 || i == 5 || i == 8 || i == 9)
                {
                    continue;
                }

                if (n % i == 0)
                {
                    isDividable = true;
                    if (highestDivider < i)
                    {
                        highestDivider = i;

                    }
                }
                else
                {
                    if (i == 2)
                    {
                        continue;
                    }
                    if (isDividable)
                    {
                        continue;
                    }
                    Console.WriteLine("Not divisible");
                    return;
                }
            }

            Console.WriteLine($"The number is divisible by {highestDivider}");
        }
    }
}
