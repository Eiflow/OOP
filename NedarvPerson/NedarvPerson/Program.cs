namespace NedarvPerson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("John Doe", 25);

            Elev elev = new Elev("Jane Doe", 17, 10);

            Console.WriteLine("Udskriv via Person-objekt:");
            person.Udskriv();

            Console.WriteLine("\nUdskriv via Elev-objekt:");
            elev.Udskriv();
        }
    }
}
