using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBil
{
    public class DieselBil : IBil
    {
        public string Farve { get; set; }
        private int kilometer;

        public int Km
        {
            get { return kilometer; }
        }

        public DieselBil(string farve, int km)
        {
            Farve = farve;
            kilometer = km;
        }

        public void UdskrivBil()
        {
            Console.WriteLine($"DieselBil - Farve: {Farve}, Km: {Km} km");
        }
    }
}
