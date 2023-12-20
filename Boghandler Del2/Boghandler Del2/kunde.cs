using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boghandler_Del2
{
    class Kunde
    {
        public string navn {  get; set; }
        public string adresse { get; set;}
        public void Indlæs(out string navn, out string adresse)
        {
            Console.Write("Indtast kundenavn: ");
            navn = Console.ReadLine();

            Console.Write("Indtast kundeadresse: ");
            adresse = Console.ReadLine();
        }
    }
}
