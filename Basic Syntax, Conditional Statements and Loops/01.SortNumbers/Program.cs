using System.Diagnostics.CodeAnalysis;
using System.Reflection;

namespace _01.SortNumbers
{
    internal class Program
    {
        static void Main()
        {
            double moneyBalance = double.Parse(Console.ReadLine());

            double sum = 0;

            string gameName = Console.ReadLine();

            while (gameName!="Game Time")
            {
                switch (gameName)
                {
                    case"OutFall 4":
                    case"RoverWatch Origins Edition":
                        if (moneyBalance >= 39.99)
                        {
                            Console.WriteLine($"Bought {gameName}");
                            moneyBalance -= 39.99;
                            sum += 39.99;
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");

                        }
                        break;
                    case"CS: OG":
                        if (moneyBalance >= 15.99)
                        {
                            Console.WriteLine($"Bought {gameName}");
                            moneyBalance -= 15.99; 
                            sum += 15.99;
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");

                        }
                        break;
                    case"Zplinter Zell":
                        if (moneyBalance >= 19.99)
                        {
                            Console.WriteLine($"Bought {gameName}");
                            moneyBalance -= 19.99; 
                            sum += 19.99;
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");

                        }
                        break;
                    case"Honored 2":
                        if (moneyBalance >= 59.99)
                        {
                            Console.WriteLine($"Bought {gameName}");
                            moneyBalance -= 59.99; 
                            sum += 59.99;
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");

                        }
                        break;
                    case"RoverWatch":   
                        if (moneyBalance >= 29.99)
                        {
                            Console.WriteLine($"Bought {gameName}");
                            moneyBalance -= 29.99; 
                            sum +=29.99;
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");

                        }
                        break;
                    default:
                        Console.WriteLine("Not Found");
                        break;

                }

                if (moneyBalance <= 0)
                {
                    Console.WriteLine("Out of money!" );
                    return;

                }

                gameName = Console.ReadLine();
            }

            Console.WriteLine($"Total spent: ${sum:f2}. Remaining: ${moneyBalance:f2}");

        }




    }
}   


