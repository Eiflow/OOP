using System.Reflection;

namespace Boghandler_Del3
{
    class Bog
    {
        public string Titel { get; set; }
        public string Forfatter { get; set; }
        public int BogId { get; set; }

        public Bog(string titel, string forfatter)
        {
            Titel = titel;
            Forfatter = forfatter;
        }

    }
}