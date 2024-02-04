namespace _07.WaterOverflow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int waterTank = 255;
            int lines = int.Parse(Console.ReadLine());
            int littersSum = 0;


            for (int i = 0; i < lines; i++)
            {
                int currentLitters = int.Parse(Console.ReadLine());

                if (waterTank - currentLitters < 0)
                {
                    Console.WriteLine("Insufficient capacity!" );
                 
                    continue;
                }
                waterTank -= currentLitters;

                littersSum += currentLitters;
            }

            Console.WriteLine(littersSum);
        }
    }
}
