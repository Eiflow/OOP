
namespace Events
{
    internal class Program
    {
        static ConsoleColor[] farver = { ConsoleColor.Red, ConsoleColor.Yellow, ConsoleColor.Green, ConsoleColor.Blue, ConsoleColor.Magenta };
        static int nuværendeFarveIndex = 0;

        static async Task Main()
        {
            Console.WriteLine("Tryk på Enter for at stoppe programmet.");

            do
            {
                Console.BackgroundColor = farver[nuværendeFarveIndex];
                Console.Clear();

                nuværendeFarveIndex = (nuværendeFarveIndex + 1) % farver.Length;

                await Task.Delay(5000);

            } while (!Console.KeyAvailable || Console.ReadKey(true).Key != ConsoleKey.Enter);
        }
    }
}
