namespace NedarvPerson_Del2
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Johnny", "Johnny", 225);

            Elev elev = new Elev("Lame", "Jame", 17, 10);

            Console.WriteLine("Udskriv via Person-objekt:");
            person.Udskriv();

            Console.WriteLine("\nUdskriv via Elev-objekt:");
            elev.Udskriv();

            Person elevSomPerson = elev;

            Console.WriteLine("\nUdskriv via Person-objektets reference til Elev-objekt:");
            elevSomPerson.Udskriv();
        }
    }
}
