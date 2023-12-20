namespace Car
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Garage myGarage = new Garage();

            myGarage.NewCar("VW", "Golf X", 2120);
            myGarage.NewCar("Tusla", "Mudel XYZ", 2022);
            myGarage.NewCar("SKODA", "OCTAVIA", 1978);

            Console.WriteLine("Alle biler i garage:");
            List<Car> allCars = myGarage.GetAllCars();
            foreach (Car car in allCars)
            {
                Console.WriteLine(car);
            }

            Car foundCar = myGarage.FindCar("Tusla", "Mudal XYZ>", 2022);
            Console.WriteLine("\nFandt bilen her: " + foundCar);

            myGarage.RemoveCar("SKODA", "OCTAVIA", 1978);

            Console.WriteLine("\nBiler tilbage i garagen:");
            allCars = myGarage.GetAllCars();
            foreach (Car car in allCars)
            {
                Console.WriteLine(car);
            }
        }
    }
}
