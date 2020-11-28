using System;

namespace Zad4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Prosze podac dodatnia liczbe nie wieksza niz 150");
            int n = int.Parse(Console.ReadLine());
            Random rnd = new Random();
            int licznik = 0;
            while (n<1)
            {
                Console.Write("Prosze o liczbe dodatnia: ");
                n = int.Parse(Console.ReadLine());
            }
            while (n > 150)
            {
                Console.Write("Liczba ma byc nie wieksza niz 150");
                n = int.Parse(Console.ReadLine());
            }
            int[] tab = new int[n];
            for (int i=0;i<n;i++)
            {
                tab[i] = rnd.Next(-1109,1110);
            }
            int max = tab[0];
            for (int i=0;i<n;i++)
            {
                if (tab[i]>max)
                {
                    max = tab[i];
                    licznik = 1;
                }
                else if (tab[i] == max)
                {
                    licznik++;
                }
            }
            Console.WriteLine("Najwieksza liczba w ciagu jest {0} i wystepuje ono w nim {1} razy", max, licznik);
            Console.ReadKey();
        }
    }
}
