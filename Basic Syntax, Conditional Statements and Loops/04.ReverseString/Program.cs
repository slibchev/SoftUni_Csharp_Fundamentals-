namespace _04.ReverseString
{
    internal class Program
    {
        static void Main()
        {
           string input = Console.ReadLine();

           char[] reversedString = input.ToCharArray();
           Array.Reverse(reversedString);
           Console.WriteLine(reversedString);
        }
    }
}
