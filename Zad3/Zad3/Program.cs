using System;

namespace Zad3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Prosze podac dlugosc ciagu do sprawdzenia");
            int n = int.Parse(Console.ReadLine());
            double[] tab = new double[n];
            int dodatnie=0;
            int ujemne=0;
            int zera=0;
            for (int i=0;i<n;i++)
            {
                Console.Write("{0} wyraz ciągu:", i + 1);
                tab[i] = double.Parse(Console.ReadLine());
            }
            for (int i=0;i<n;i++)
            {
                if (tab[i] > 0)
                {
                    dodatnie++;
                }
                else if (tab[i] < 0)
                {
                    ujemne++;
                }
                else if(tab[i]==0)
                {
                    zera++;
                }
            }
            Console.Write("W ciagu znajduje sie {0} liczb dodatnich, {1} liczb ujemnych i {2} zer", dodatnie, ujemne, zera);
            Console.ReadKey();
        }
    }
}
