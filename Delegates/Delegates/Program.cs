namespace Delegates
{
    delegate int BeregnDelegate(int a, int b);
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                BeregnDelegate beregnDelegate = Add;

                int valg;

                do
                {
                    Console.WriteLine("Vælg operation:");
                    Console.WriteLine("1. Plus");
                    Console.WriteLine("2. minus");
                    Console.WriteLine("3. Afslut");

                    if (int.TryParse(Console.ReadLine(), out valg))
                    {
                        switch (valg)
                        {
                            case 1:
                                Console.Clear();
                                beregnDelegate = Add;
                                break;

                            case 2:
                                Console.Clear();
                                beregnDelegate = Sub;
                                break;

                            case 3:
                                Console.Clear();
                                Console.WriteLine("Programmet afsluttes.");
                                break;

                            default:
                                Console.Clear();
                                Console.WriteLine("Ugyldigt valg. Prøv igen.");
                                break;
                        }

                        if (valg != 0)
                        {
                            Console.Write("Indtast det første tal: ");
                            int tal1 = Convert.ToInt32(Console.ReadLine());

                            Console.Write("Indtast det andet tal: ");
                            int tal2 = Convert.ToInt32(Console.ReadLine());

                            int resultat = beregnDelegate(tal1, tal2);

                            Console.WriteLine($"Resultatet er: {resultat}");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Ugyldig indtastning. Prøv igen.");
                    }

                } while (valg != 0);
            }

            static int Add(int a, int b)
            {
                return a + b;
            }

            static int Sub(int a, int b)
            {
                return a - b;
            }
        }
    }
}
