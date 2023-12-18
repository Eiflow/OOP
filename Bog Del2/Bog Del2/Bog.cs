namespace Bog_Del2
{
    public class Bog
    {
        private string titel;
        private string forfatter;
        private int udgivelsesår;

        public Bog()
        {
        }

        public Bog(string titel, string forfatter, int udgivelsesår)
        {
            this.titel = titel;
            this.forfatter = forfatter;
            this.udgivelsesår = udgivelsesår;
        }

        public string Titel
        {
            get { return titel; }
            set { titel = value; }
        }

        public string Forfatter
        {
            get { return forfatter; }
            set { forfatter = value; }
        }

        public int Udgivelsesår
        {
            get { return udgivelsesår; }
            set { udgivelsesår = value; }
        }

        public string Isbn { get; set; }

        public void VisBogInfo()
        {
            Console.WriteLine($"Titel: {Titel}");
            Console.WriteLine($"Forfatter: {Forfatter}");
            Console.WriteLine($"Udgivelsesår: {Udgivelsesår}");
            Console.WriteLine($"ISBN: {Isbn}");
            Console.WriteLine();
        }
    }
}
