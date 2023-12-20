using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NedarvPerson_Del2
{
    public class Base
    {
        public string Fornavn { get; set; }
        public string Efternavn { get; set; }
        public Base(string fornavn, string efternavn)
        {
            Fornavn = fornavn;
            Efternavn = efternavn;
        }
    }
}
