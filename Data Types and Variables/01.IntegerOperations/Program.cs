namespace _01.IntegerOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secodNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());
            int fourthdNumber = int.Parse(Console.ReadLine());


            int addition = firstNumber + secodNumber;
            int devision = addition / thirdNumber;
            int multiplication = devision * fourthdNumber;

            Console.WriteLine(multiplication);




        }
    }
}
