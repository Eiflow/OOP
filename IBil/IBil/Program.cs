namespace IBil
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IBil benzilBil = new BenzilBil("Blå", 15000);

            IBil dieselBil = new DieselBil("Grøn", 20000);

            benzilBil.UdskrivBil();
            dieselBil.UdskrivBil();
        }
    }
}
