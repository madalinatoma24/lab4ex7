using System;

namespace lab4ex7
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Ex 7 dificultate ridicata
            Scrieti o functie recursiva care pentru un numar “n” primit ca parametru, va
            afisa urmatoarea piramida a numerelor:
             */
            Console.WriteLine("Piramida");
            GetPiramida(8,8);
        }

        static int GetPiramida(int n, int final)
        {
            n = n - 1;
            if (n == 0)
            {
                return n;
            }
            for (int i = 0; i < n; i++)
            {
                Console.Write($"{ n }");
            }
           
            Console.WriteLine();
            return GetPiramida(n,final);
        }
    }
}
