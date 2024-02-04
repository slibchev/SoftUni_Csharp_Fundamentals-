namespace _09.SpiceMustFlow
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int startingYield = int.Parse(Console.ReadLine());
            int days = 0;
            int spicesExtracted = 0;

            if (startingYield < 100)
            {

                Console.WriteLine(days);
                Console.WriteLine(spicesExtracted);
                return;
            }

            while (startingYield >= 100)
            {

                days++;
                spicesExtracted += startingYield-26;





                startingYield -= 10;
            }

            spicesExtracted -= 26;

            Console.WriteLine(days);
            Console.WriteLine(spicesExtracted);

        }
    }
}
