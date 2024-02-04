namespace _03.Elevator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int peopleToElevate = int.Parse(Console.ReadLine());
            double elevatorCapacity = int.Parse(Console.ReadLine());

            double elevatorRuns = Math.Ceiling(peopleToElevate / elevatorCapacity);

            if (peopleToElevate < elevatorCapacity)
            {
                elevatorRuns = 1;
            }
            //if (peopleToElevate % elevatorRuns != 0)
            //{
            //    elevatorRuns += 1;
            //}

            Console.WriteLine(elevatorRuns);

        }
    }
}
