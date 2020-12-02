using System;

namespace Zadatak_5._1._2___Umnozak_Kvocijent
{
    class Program
    {
        static void Main(string[] args)
        {
            //5.1.2 - Umnožak i kvocijent
            //Program koji traži unos 2 cijela broja i prikazuje 
            //umnožak i kvocijent

            int a = 0, b = 0;
            Console.Write("Unesite 1. broj:");
            a = int.Parse(Console.ReadLine());
            Console.Write("Unesite 2.broj:");
            b = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Umnožak: {0}", a * b);
            Console.WriteLine("Kvocijent {0}", (float)a / (float)b);
            Console.WriteLine("Pritisnite enter za kraj");
            ConsoleKeyInfo consoleKeyInfo = Console.ReadKey();

        }
    }
}
