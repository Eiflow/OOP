using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NedarvPerson_Del2
{
    public class Elev : Person
    {
        public int KlasseNr { get; set; }

        public Elev(string fornavn, string efternavn, int alder, int klasseNr) : base(fornavn, efternavn, alder)
        {
            KlasseNr = klasseNr;
        }
        /*public Elev(string navn, int alder, int klasseNr)
        {
            Navn = navn;
            Alder = alder;
            KlasseNr = klasseNr;
        }*/
        public override void Udskriv()
        {
            Console.WriteLine($"Navn: {Fornavn} {Efternavn}, Alder: {Alder}, KlasseNr: {KlasseNr}");
        }
    }
}
