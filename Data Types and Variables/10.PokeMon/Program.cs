namespace _10.PokeMon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pokePower = int.Parse(Console.ReadLine());
            int targetsDistance = int.Parse(Console.ReadLine());
            int exhaustionFactor = int.Parse(Console.ReadLine());

            int halfPokepower = pokePower / 2;

            int targetsPoked = 0;

            while (pokePower >= targetsDistance)
            {

                if (pokePower == halfPokepower)
                {
                    if (exhaustionFactor == 0)
                    {
                        pokePower -= targetsDistance;
                        targetsPoked++;
                    }
                    else
                    {
                      pokePower /= exhaustionFactor;

                    }

                }
                else
                {
                    
                  pokePower -= targetsDistance;
                  targetsPoked++;

                }
            }

            Console.WriteLine(pokePower);
            Console.WriteLine(targetsPoked);

        }
    }
}
