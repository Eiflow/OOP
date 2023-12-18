using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bog
{
    public class Bog
    {
        private string titel;
        private string forfatter;
        private int udgivelseår;


        public Bog(string titel, string forfatter, int udgivelseår)
        {
            this.titel = titel;
            this.forfatter = forfatter;
            this.udgivelseår = udgivelseår;
        }
        public void VisBogInfo()
        {
            Console.WriteLine($"Titel: {titel}");
            Console.WriteLine($"Forfatter: {forfatter}");
            Console.WriteLine($"Udgivelses År: {udgivelseår}");

        }
    }
}
