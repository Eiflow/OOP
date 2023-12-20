using System.Xml;

namespace Boghandler_Del3
{
    internal class Program
    {
        static void Main()
        {
            Forlag forlag = new Forlag();

            Bog bog = new Bog("Den gamle ubåd", "Peter Madsen");
            forlag.Modtage(bog);

            Bog bog2 = new Bog("Bog 2", "Ham den gamle");
            forlag.Modtage(bog2);

            Bog bog3 = new Bog("Bog 3", "Et eller andet");
            forlag.Modtage(bog3);
        }
    }
}
