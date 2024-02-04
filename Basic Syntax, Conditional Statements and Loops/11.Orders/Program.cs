



namespace _11.Orders
{
    internal class Program
    {
        static void Main()
        {
            int shopOrders = int.Parse(Console.ReadLine());

            double total = 0;

            for (int i = 0; i < shopOrders; i++)
            {

                double capsulePrice = double.Parse(Console.ReadLine());
                int days = int.Parse(Console.ReadLine());
                int capsuleCount = int.Parse(Console.ReadLine());

                double singleOrderPrice = days * capsuleCount * capsulePrice;
                Console.WriteLine($"The price for the coffee is: ${singleOrderPrice:f2}");
                total += singleOrderPrice;
                singleOrderPrice = 0;

            }

            Console.WriteLine($"Total: ${total:f2}");

        }
    }
}
