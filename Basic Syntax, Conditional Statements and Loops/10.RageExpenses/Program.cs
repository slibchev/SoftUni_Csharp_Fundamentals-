/*
7
2
3
4
5
 */

namespace _10.RageExpenses
{
    internal class Program
    {
        static void Main()
        {
            int gameLost = int.Parse(Console.ReadLine());
            double headSetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());


            double rageExpences = 0;

            for (int loses = 1; loses <=gameLost; loses++)
            {
                if (loses % 2 ==0) rageExpences += headSetPrice;
                if (loses % 3 == 0) rageExpences += mousePrice;
                if(loses % 6 == 0) rageExpences += keyboardPrice;
                if(loses % 12 == 0) rageExpences += displayPrice;
            }

            Console.WriteLine($"Rage expenses: {rageExpences:f2} lv.");

        }
    }
}
