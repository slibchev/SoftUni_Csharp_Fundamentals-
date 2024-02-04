namespace _11.MultiplicationTable_._0
{
    internal class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int multiplyer = int.Parse(Console.ReadLine());

            if (multiplyer > 10)
            {
                Console.WriteLine($"{n} X {multiplyer} = {n * multiplyer}");

            }

            for (int i = multiplyer; i <= 10; i++)
            {
                int currentResult = n * i;

               

                Console.WriteLine($"{n} X {i} = {currentResult}");

            }
        }
    }
}
