using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBil
{
    public class BenzilBil : IBil
    {
        public string Farve { get; set; }
        private int kilometer;

        public int Km
        {
            get { return kilometer; }
        }

        public BenzilBil(string farve, int km)
        {
            Farve = farve;
            kilometer = km;
        }

        public void UdskrivBil()
        {
            Console.WriteLine($"BenzilBil - Farve: {Farve}, Km: {Km} km");
        }
    }
}
