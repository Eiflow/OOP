namespace IBil_Enumerations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Farve valgtFarve = Farve.Grøn;

            UdskrivFarve(valgtFarve);

            Console.ReadLine();
        }

        static void UdskrivFarve(Farve farve)
        {
            Console.WriteLine($"Farven er: {farve}");
        }

        //Sådan vil det se ud unden enumerations
        /*static void Main(string[] args)
        {
            string valgtFarve = "Grøn";

            UdskrivFarve(valgtFarve);

            Console.ReadLine();
        }

        static void UdskrivFarve(string farve)
        {
            Console.WriteLine($"Farven er: {farve}");
        }
        */
    }
}
