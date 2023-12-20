using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NedarvPerson
{
    public class Person
    {
        public string Navn { get; set; }
        public int Alder { get; set; }

        public Person(string Navn, int alder) 
        {
            Navn = Navn;
            Alder = alder;
        }
        public void Udskriv()
        {
            Console.WriteLine($"Navn: {Navn}, Alder: {Alder}");
        }
    }
}
