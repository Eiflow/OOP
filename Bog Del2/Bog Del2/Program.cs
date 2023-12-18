namespace Bog_Del2
{
    class Program
    {
        static void Main()
        {
            Bog bog1 = new Bog();
            bog1.Titel = "The Great Gatsby";
            bog1.Forfatter = "F. Scott Fitzgerald";
            bog1.Udgivelsesår = 1925;

            Bog bog2 = new Bog("1984", "George Orwell", 1949);
            bog2.Isbn = "978-0451524935";

            Bog bog3 = new Bog { Titel = "The Catcher in the Rye", Forfatter = "J.D. Salinger", Udgivelsesår = 1951, Isbn = "978-7543331723" };

            bog1.VisBogInfo();
            bog2.VisBogInfo();
            bog3.VisBogInfo();

            Console.ReadKey();
        }
    }
}
