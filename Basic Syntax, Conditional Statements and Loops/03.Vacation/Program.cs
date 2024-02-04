namespace _03.Vacation
{
    internal class Program
    {
        static void Main()
        {
            int people = int.Parse(Console.ReadLine());
            string groupType = Console.ReadLine();
            string day = Console.ReadLine();

            double totalPrice = 0;
            double discount = 0;

            if (groupType == "Students")
            {
                
                if (day == "Friday")
                {
                    totalPrice = people * 8.45;
                }
                else if (day == "Saturday")
                {
                    totalPrice = people * 9.80;
                }
                else if (day == "Sunday")
                {
                    totalPrice = people * 10.46;
                }
            }
            else if (groupType == "Business")
            {
                if (day == "Friday")
                {
                    if (people >= 100)
                    {
                        totalPrice = (people - 10) * 10.90;
                    }
                    else
                    {
                        totalPrice = people * 10.90;
                    }
                }
                else if (day == "Saturday")
                {
                    if (people >= 100)
                    {
                        totalPrice = (people - 10) * 15.60;
                    }
                    else
                    {
                         totalPrice = people * 15.60;
                    }
                }
                else if (day == "Sunday")
                {
                    if (people >= 100)
                    {
                        totalPrice = (people - 10) * 16;
                    }
                    else
                    {
                      totalPrice = people * 16;   
                    }
                }
            }
            else if(groupType == "Regular")
            {
                if (day == "Friday")
                {
                    totalPrice = people * 15;
                }
                else if (day == "Saturday")
                {
                    totalPrice = people * 20;
                }
                else if (day == "Sunday")
                {
                    totalPrice = people * 22.50;
                }
            }

            if (groupType == "Students" && people >= 30)
            {
                discount = 0.15;
                totalPrice = totalPrice - totalPrice * discount;
            }
            else if (groupType == "Regular" && people >= 10 && people<= 20)
            {
                discount = 0.05;
                totalPrice = totalPrice - totalPrice * discount;
            }

            Console.WriteLine($"Total price: {totalPrice:f2}");
        }
    }
}
