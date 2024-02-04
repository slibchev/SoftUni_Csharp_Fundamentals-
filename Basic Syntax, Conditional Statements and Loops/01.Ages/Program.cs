
/*
20

1

100
 */


namespace _01.Ages
{
    internal class Program
    {
        static void Main(string[] args)
        {
            short age = short.Parse(Console.ReadLine());

            string gender = string.Empty;

            if (age >= 0 && age <= 2)
            {
                gender = "baby";
            }
            else if(age >2 && age <= 13) 
            {
                gender = "child";
            }
            else if (age > 13 && age <= 19)
            {
                gender = "teenager";
            }
            else if (age > 19 && age <= 65)
            {
                gender = "adult";
            }
            else 
            {
                gender = "elder";
            }

            Console.WriteLine(gender);

        }
    }
}
