using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boghandler_Del3
{
    class Forlag
    {
        private int næsteBogNr = 1;

        public void Modtage(Bog bog)
        {
            bog.BogId = næsteBogNr;
            næsteBogNr++;
            Console.WriteLine($"Modtaget bog: {bog.BogId}. {bog.Titel}, {bog.Forfatter} forfatter");
        }
    }
}
