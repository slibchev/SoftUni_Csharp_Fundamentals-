namespace _08.TownInfo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string cityName = Console.ReadLine();
            int population = int.Parse(Console.ReadLine());
            int squareMeters = int.Parse(Console.ReadLine());


            Console.WriteLine($"Town {cityName} has population of {population} and area {squareMeters} square km.");

        }
    }
}
