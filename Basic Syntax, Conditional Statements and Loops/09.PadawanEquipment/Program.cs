/*
100
2
1.0
2.0
3.0
 
================
100
42
12.0
4.0
3.0


 */



namespace _09.PadawanEquipment
{
    internal class Program
    {
        static void Main()
        {
            double budget = double.Parse(Console.ReadLine());
            int studentCount = int.Parse(Console.ReadLine());
            double saberPrice = double.Parse(Console.ReadLine());
            double robes = double.Parse(Console.ReadLine());
            double belts = double.Parse(Console.ReadLine());

            double saberBackup = Math.Ceiling(studentCount *0.1);
            double SaberTotalPrice = (studentCount + saberBackup) * saberPrice;

            double robesTotalPrice = studentCount * robes;

            
            double beltDisscount = 0;
            if (studentCount >= 6)
            {
                 beltDisscount = Math.Floor((double)studentCount / 6);
            }
            
            double beltTotalPrice = (studentCount - beltDisscount) * belts;



            double EquipmetPrice = SaberTotalPrice + robesTotalPrice + beltTotalPrice;

            //double moneyNeeded = studentCount * singleEquipmetPrice;

            Console.WriteLine(budget >= EquipmetPrice
                ? $"The money is enough - it would cost {EquipmetPrice:f2}lv."
                : $"John will need {EquipmetPrice - budget:f2}lv more.");
        }
    }
}
