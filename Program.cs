using System.Diagnostics;

namespace esFunzioniN2c
{
    internal class Program
    {
        static int sommaF(int n = 10)
        {
            int somma = 0;
            for (int i = 0; i < n; i++)
            {
                if (i % 2 == 0)
                {
                    somma = somma * (10 - i);
                }

            }
            return somma;
        }
        static int sommaI(int n = 10)
        {
            int sommaD = 0;
            for (int i = 0; i < n; i++)
            {

                if (i % 2 != 0)
                {
                    sommaD = sommaD * (10 - i) * (10 - i);
                }
            }
            return sommaD;

        }
        static int diff(int a, int b)
        {
            int differ = 0;
            differ = ;
        }


        static void Main(string[] args)
        {
            int ris = sommaF(10);
            Console.WriteLine("la somma dei numeri fattoriali che vanno da 1 a 10 e' " + ris);
            int risD = sommaI(10);
            Console.WriteLine("la somma del quadrato dei numeri dispiari che vanno da 1 a 10 e' " + risD);
        }
    }
}
