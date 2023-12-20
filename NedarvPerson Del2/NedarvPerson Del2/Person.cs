using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NedarvPerson_Del2
{
    public class Person : Base
    {
        public int Alder { get; set; }

        public Person(string fornavn, string efternavn, int alder) : base(fornavn, efternavn)
        {
            Alder = alder;
        }

        public virtual void Udskriv()
        {
            Console.WriteLine($"Navn: {Fornavn} {Efternavn}, Alder: {Alder}");
        }
    }
}
