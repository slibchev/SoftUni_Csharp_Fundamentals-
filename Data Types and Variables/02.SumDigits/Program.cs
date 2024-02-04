namespace _02.SumDigits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            string strNum = number.ToString();
            int sum = 0;

            for (int i = 0; i < strNum.Length; i++)
            {
                int currentNum = strNum[i]-'0';
                sum += currentNum;
            }

            Console.WriteLine(sum);
            
        }
    }
}
