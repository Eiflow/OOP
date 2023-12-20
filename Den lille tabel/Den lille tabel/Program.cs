using System;

class Program
{
    static void Main()
    {
        Console.Write("Angiv antallet af rækker i den lille tabel: ");
        if (int.TryParse(Console.ReadLine(), out int antalRækker))
        {
            UdskrivLilleTabel(antalRækker);
        }
        else
        {
            Console.WriteLine("Ugyldig indtastning. Indtast venligst et heltal.");
        }
    }

    static void UdskrivLilleTabel(int antalRækker)
    {
        for (int i = 1; i <= antalRækker; i++)
        {
            for (int j = 1; j <= 10; j++)
            {
                Console.Write($"{i * j}\t");
            }
            Console.WriteLine();
        }
    }
}
