using System;
namespace Zad2
{
    class Program
    {
        static void Checker(int[,] tab, int n)
        {
            int suma1 = 0;
            int suma2 = 0;
            int wskaz = 0;
            for (int i=0;i<n;i++)
            {
                for(int j=0;j<n;j++)
                {
                    suma1 = suma1 + tab[i, j];
                }
                if(suma1>suma2)
                {
                    suma2 = suma1;
                    wskaz = i;
                    suma1 = 0;
                }
            }
            Console.WriteLine("Najwieksza suma znajduje sie w kolumnie {0} i wynosi {1}", wskaz, suma2);
            Console.ReadKey();
        }
        static void Lista(int n)
        {
            int[ , ] tab= new int[n, n];
            Console.WriteLine("Prosze podac wartosci dla pol o następujących współrzędnych w tablicy o wymiarach {0}x{0}", n);
            for (int j=0; j<n; j++)
            {
                for (int i = 0; i < n; i++)
                {
                    Console.Write("({0},{1}) :", i, j);
                    tab[i, j] = int.Parse(Console.ReadLine());
                }   
            }
            Checker(tab, n);
        }           
        static void Main(string[] args)
        {
            Console.WriteLine("Prosze podac dodatnia liczbe naturalna mniejsza, lub rowna 10");
            int n = int.Parse(Console.ReadLine());
            while (n>10)
            {
                Console.WriteLine("Prosze o dodatnia liczbe mniejsza, lub rowna 10");
                n = int.Parse(Console.ReadLine());
            }
            Lista(n);

        }
    }
}
