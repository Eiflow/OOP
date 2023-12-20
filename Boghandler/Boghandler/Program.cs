namespace Boghandler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bog smukBog = new Bog
            {
                str = "Bare en titel",
                antalSider = 100
            };

            Boghandler boghandler = new Boghandler();

            boghandler.Sælg(smukBog);

            Console.WriteLine($"Titel: {smukBog.str} Antal Sider: {smukBog.antalSider}");
        }
    }
}
