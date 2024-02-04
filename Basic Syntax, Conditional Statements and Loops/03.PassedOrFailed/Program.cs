namespace _03.PassedOrFailed
{
    internal class Program
    {
        static void Main()
        {
            float grade = float.Parse(Console.ReadLine());

            if (grade >= 3)
            {
                Console.WriteLine("Passed!");
            }
            else
            {
                Console.WriteLine("Failed!");
            }
        }
    }
}
