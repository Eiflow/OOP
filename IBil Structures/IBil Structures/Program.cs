namespace IBil_Structures
{
    internal class Program
    {
        static void Main()
        {
            Bil bil1;
            bil1.Farve = "Lilla";
            bil1.Km = 100000;
            bil1.Hk = 250;

            Bil bil2 = new Bil("Grøn", 20000, 400);

            Console.WriteLine("bil1:");
            bil1.Udskriv();

            Console.WriteLine("\nbil2:");
            bil2.Udskriv();

            Bil bil3 = bil1;

            bil1.Farve = "Gul";

           
            Console.WriteLine("\nEfter farveændring:");
            bil1.Udskriv();

            Console.WriteLine("\nBil3 (kopi af bil1):");
            bil3.Udskriv();
        }
    }
}
