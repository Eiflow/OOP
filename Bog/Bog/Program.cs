namespace Bog
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bog bog1 = new Bog("Harry Potter", "J.K. Rowling", 1997);
            Bog bog2 = new Bog("The Hobbit", "J.R.R. Tolkien", 1937);
            Bog bog3 = new Bog("To Kill a Mockingbird", "Harper Lee", 1960);

            bog1.VisBogInfo();
            bog2.VisBogInfo();
            bog3.VisBogInfo();

            Console.ReadKey();
        }
    }
}
