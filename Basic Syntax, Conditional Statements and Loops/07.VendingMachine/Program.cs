/*
1
1
0.5
0.6
Start
Coke
Soda
Crisps
End

=========================
1
Start
Nuts
Coke
End
 */


using System.Runtime.InteropServices;

namespace _07.VendingMachine
{
    internal class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            

             double coinsSum = 0;
          
            while (input!="Start")
            {
                double coins = double.Parse(input);
                bool isValid = coins == 0.1|| coins == 0.2|| coins == 0.5|| coins == 1|| coins == 2;

                if (isValid)
                {
                    coinsSum += coins;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {coins}");
                }

                input = Console.ReadLine();
            }


            string product = Console.ReadLine();


            while (product != "End")
            {
                if (product != "Nuts" && product != "Water" && product != "Crisps" && product != "Soda" && product != "Coke")
                { 
                    Console.WriteLine("Invalid product");
                    product = Console.ReadLine();
                    continue;
                }

                switch (product)
                {
                    case "Nuts":
                        
                        if (coinsSum < 2)
                        {
                            Console.WriteLine($"Sorry, not enough money");
                            
                        }
                        else
                        {
                            coinsSum -= 2.0;
                            Console.WriteLine($"Purchased {product.ToLower()}");
                        }
                        break;
                    case "Water":
                        
                        if (coinsSum < 0.7)
                        {
                            Console.WriteLine($"Sorry, not enough money");
                            
                        }
                        else
                        {
                            coinsSum -= 0.7;
                            Console.WriteLine($"Purchased {product.ToLower()}");
                        }
                        break;
                    case "Crisps":
                        
                        if (coinsSum < 1.5)
                        {
                            Console.WriteLine($"Sorry, not enough money"); 
                        }
                        else
                        {
                            coinsSum -= 1.5;
                            Console.WriteLine($"Purchased {product.ToLower()}");
                        }
                        break;
                    case "Soda":
                        
                        if (coinsSum < 0.8)
                        {
                            Console.WriteLine($"Sorry, not enough money"); 
                        }
                        else
                        {
                            coinsSum -= 0.8;
                            Console.WriteLine($"Purchased {product.ToLower()}");
                        }
                        break;
                    case "Coke":
                        
                        if (coinsSum < 1)
                        {
                            Console.WriteLine($"Sorry, not enough money"); 
                        }
                        else
                        {
                            coinsSum -= 1;
                            Console.WriteLine($"Purchased {product.ToLower()}");
                        }
                        break;
                }

                product = Console.ReadLine();
               

            }
            Console.WriteLine($"Change: {coinsSum:f2}");

                




            

           

        }
    }
}
