namespace Exception_Handling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv en dato (dd-mm-yyyy) før dagens dato:");

            string input = Console.ReadLine();

            try
            {
                CheckDato(input);

                Console.WriteLine("Datoen er gyldig og ligger før dagens dato.");
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"Fejl: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Fejl: {ex.Message}");
            }

            Console.ReadLine();
        }

        static void CheckDato(string inputDato)
        {
            if (!DateTime.TryParseExact(inputDato, "dd-MM-yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime dato))
            {
                throw new FormatException("Ugyldigt datoformat. Skriv datoen i formatet dd-mm-yyyy.");
            }

            if (dato >= DateTime.Now.Date)
            {
                throw new Exception("Datoen skal være før dagens dato.");
            }
        }
    }
}
