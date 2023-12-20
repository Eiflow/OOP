using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car
{
    public class Car
    {
        public string Model { get; set; }
        public string Brand {  get; set; }
        public int Year { get; set; }

        public Car(string model, string brand, int year) 
        {
            Model = model;
            Brand = brand;
            Year = year;
        }
        public override string ToString()
        {
            return $"{Year} {Brand} {Model}";
        }
    }
}
