namespace Bog_Del2
{
    class Program
    {
        static void Main()
        {
            Bog bog1 = new Bog
            {
                Titel = "Test",
                Forfatter = "Tested",
                Udgivelsesår = 1925,
                Isbn = "Test",
            };

            Bog bog2 = new Bog { Titel = "The Catcher in the Rye", 
                Forfatter = "J.D. Salinger", 
                Udgivelsesår = 1951, 
                Isbn = "978-7543331723" 
            };

            Console.WriteLine($"Faggot bog nummer one {bog1.Titel}");
            bog1.VisBogInfo();
            bog2.VisBogInfo();

            Console.ReadKey();
        }
    }
}
