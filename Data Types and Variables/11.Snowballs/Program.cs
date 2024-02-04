using System.ComponentModel;

namespace _11.Snowballs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int snowBallCount = int.Parse(Console.ReadLine());

            double bestSnowballValue = 0;
            int bestQuality = 0;
            int snowBallSnowRes  = 0;
            int snowBallTimeRes  = 0;

            for (int i = 0; i < snowBallCount; i++)
            {
                int snowBallSnow = int.Parse(Console.ReadLine());
                int snowBallTime = int.Parse(Console.ReadLine());
                int snowBallQuality = int.Parse(Console.ReadLine());


                int middcalculation = snowBallSnow / snowBallTime ;
                double currentValue = Math.Pow(middcalculation, snowBallQuality);

               if (bestSnowballValue < currentValue)
               {
                   bestSnowballValue = currentValue;
                   snowBallSnowRes = snowBallSnow;
                   snowBallTimeRes = snowBallTime;
                   bestQuality = snowBallQuality;
               }
            }
            Console.WriteLine($"{snowBallSnowRes} : {snowBallTimeRes} = {bestSnowballValue} ({bestQuality})");

        }
    }
}
