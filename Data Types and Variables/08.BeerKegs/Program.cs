/*
3
Keg 1
10
10
Keg 2
20
20
Keg 3
10
30
 */
namespace _08.BeerKegs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int kegCount = int.Parse(Console.ReadLine());

            double biggestKeg = 0;
            string biggestKegName = string.Empty;


            for (int i = 0; i < kegCount; i++)
            {
                string kegModel = Console.ReadLine();
                double kegRadius = double.Parse(Console.ReadLine());
                int kegHeight = int.Parse(Console.ReadLine());

                double kegVolume = Math.PI * Math.Pow(kegRadius, 2) * kegHeight;

                //biggestKeg = kegVolume;

                if (kegVolume > biggestKeg)
                {
                    biggestKeg = kegVolume;
                    biggestKegName = kegModel;
                }


            }

            Console.WriteLine(biggestKegName);
        }
    }
}
