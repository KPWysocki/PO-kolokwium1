using System;

namespace Kalkulator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj znak porządanej operacji oraz liczby na których operacja ma byc wykonana:");
            char operation = char.Parse(Console.ReadLine());
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double wynik = 0;
            if (operation == '+')
            {
                wynik = a + b;
                Console.WriteLine("Wynik dodawania to: {0}", wynik);
            }
            else if (operation == '-')
            {
                wynik = a - b;
                Console.WriteLine("Wynik odejmowania to: {0}", wynik);
            }
            else if (operation == '*')
            {
                wynik = a * b;
                Console.WriteLine("Wynik mnożenia to: {0}", wynik);
            }
            else if (operation == '/')
            {
                while (b == 0)
                {
                    Console.WriteLine("nie można dzielic przez 0");
                    b = double.Parse(Console.ReadLine());
                }
                wynik = a / b;
                Console.WriteLine("Wynik operacji dzielenia to: {0}", wynik);
            }

            Console.ReadKey();

        }
    }
}