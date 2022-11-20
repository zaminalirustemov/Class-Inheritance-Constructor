namespace ConsoleApp3
{
    internal class Car
    {
        public Car(string brand, string model, double currentfuel, double fuelfor1km, double millage)
        {
            this.Brand = brand;
            this.Model = model;
            this.CurrentFuel=currentfuel;
            this.FuelFor1Km=fuelfor1km;
            this.Millage=millage;
        }
        public string Brand;
        public string Model;
        public double CurrentFuel;
        public double FuelFor1Km;
        public double Millage;

        public double Drive(double distance)
        {

            if (distance <= CurrentFuel / FuelFor1Km)
            {
                CurrentFuel -= (distance * FuelFor1Km);
                Millage += distance;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("This distance can be traveled.");
                Console.WriteLine($"---Remaining fuel {CurrentFuel} liter.");
                Console.WriteLine($"---The distance the car has traveled so far {Millage} km.");

            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("There is not enough fuel.");
            }

            return CurrentFuel;
        }
    }
}
