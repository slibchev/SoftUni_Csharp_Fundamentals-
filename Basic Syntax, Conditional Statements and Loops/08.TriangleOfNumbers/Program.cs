namespace _08.TriangleOfNumbers
{
    internal class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());


            for (int row = 1; row <=n; row++)
            {

                for (int colum = 1; colum <=row; colum++)
                {
                    Console.Write(row+" ");
                }

                Console.WriteLine();


            }




        }
    }
}
