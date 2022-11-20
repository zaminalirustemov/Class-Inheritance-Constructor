using System.Transactions;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car("Lada", "2107", 27, 0.092, 56000);

            while (car.CurrentFuel >= 0)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("Enter the distance to be traveled (in km):");
                double distance = Convert.ToDouble(Console.ReadLine());
                car.Drive(distance);
            }

        }
    }
}