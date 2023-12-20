using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car
{
    public class Garage
    {
        private List<Car> cars;

        public Garage()
        {
            cars = new List<Car>();
        }
        public void NewCar(string model, string brand, int year) 
        { 
            Car newCar = new Car(model, brand, year);
            cars.Add(newCar);
            Console.WriteLine($"Ny bil er tilføjet {newCar}");
        }
        public Car FindCar(string model, string brand, int year)
        {
            return cars.Find(car => car.Model == model && car.Brand == brand && car.Year == year);
        }

        public List<Car> GetAllCars()
        {
            return new List<Car>(cars);
        }

        public void RemoveCar(string model, string brand, int year)
        {
            Car carToRemove = FindCar(model, brand, year);
            if (carToRemove != null)
            {
                cars.Remove(carToRemove);
                Console.WriteLine($"Fjernet bilen: {carToRemove}");
            }
            else
            {
                Console.WriteLine("Bil blev ikke fundet i garagen.");
            }
        }
    }
}
