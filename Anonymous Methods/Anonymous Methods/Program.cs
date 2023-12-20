delegate int MyDelegate(int p, int q);
namespace Anonymous_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyDelegate arithMethod = delegate (int c, int d)
            {
                if (c > d)
                    return c;
                else
                    return d;
            };

            Console.WriteLine("Det største af tallene er: {0}", arithMethod(3, 7));
        }
    }
}
