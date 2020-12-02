using System;

namespace Zadatak_5._1._1___Zbroj_Razlika
{
    class Program
    {
        static void Main(string[] args)
        {
            //5.1.1 - Zbroj i razlika
            //Program koji traži unos 2 cijela broja i prikazuje
            //na ekranu njihov zbroj te razliku

            int a = 0, b = 0;
            Console.Write("Unesite 1. broj: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Unesite 2. broj: ");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Zbroj: {0}", a + b);
            Console.WriteLine("Razlika: {0}", a - b);

            Console.ReadKey();
        }
    }
}
