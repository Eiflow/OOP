namespace Boghandler_Del2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string tal;

            Bog smukBog = new Bog
            {
                str = "Bare en titel",
                antalSider = 100
            };

            Kunde nyKunde = new Kunde();

            Boghandler boghandler = new Boghandler();

            boghandler.Sælg(smukBog);

            Console.WriteLine($"Titel: {smukBog.str} Antal Sider: {smukBog.antalSider}");
            string kundeNavn, kundeAdresse;
            nyKunde.Indlæs(out kundeNavn, out kundeAdresse);
            Console.WriteLine($"Kundeoplysninger: Navn - {kundeNavn}, Adresse - {kundeAdresse}");
            Console.Write("Tryk en tast for at forsætte... ");
            Console.ReadKey();
            Console.Clear();
            Console.Write("Indtast et tal af Typen Double ");
            tal = Console.ReadLine();
            if (double.TryParse(tal, out double idk))
            {
                Console.WriteLine($"Indtastet tal: {idk}");
            }
            else
            {
                Console.WriteLine("Ugyldigt input. Indtast venligst et gyldigt tal af typen Double.");
            }


        }
    }
}