using System;
using System.Globalization;

namespace ProjetosBeecrowd
{
    internal class _1021
    {
        static void Main(string[] args)
        {

            double N;
            int resto, nota, moeda, calculo;

            N = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            resto = (int)(N * 100.0 + 0.5);

            Console.WriteLine("NOTAS:");
            nota = 100;
            calculo = resto / (nota * 100);
            Console.WriteLine(calculo + " nota(s) de R$ " + nota + ".00");
            resto = resto % (nota * 100);

            nota = 50;
            calculo = resto / (nota * 100);
            Console.WriteLine(calculo + " nota(s) de R$ " + nota + ".00");
            resto = resto % (nota * 100);

            nota = 20;
            calculo = resto / (nota * 100);
            Console.WriteLine(calculo + " nota(s) de R$ " + nota + ".00");
            resto = resto % (nota * 100);

            nota = 10;
            calculo = resto / (nota * 100);
            Console.WriteLine(calculo + " nota(s) de R$ " + nota + ".00");
            resto = resto % (nota * 100);

            nota = 5;
            calculo = resto / (nota * 100);
            Console.WriteLine(calculo + " nota(s) de R$ " + nota + ".00");
            resto = resto % (nota * 100);

            nota = 2;
            calculo = resto / (nota * 100);
            Console.WriteLine(calculo + " nota(s) de R$ " + nota + ".00");
            resto = resto % (nota * 100);

            Console.WriteLine("MOEDAS:");

            moeda = 100;
            calculo = resto / moeda;
            Console.WriteLine(calculo + " moeda(s) de R$ 1.00");
            resto = resto % moeda;

            moeda = 50;
            calculo = resto / moeda;
            Console.WriteLine(calculo + " moeda(s) de R$ 0.50");
            resto = resto % moeda;

            moeda = 25;
            calculo = resto / moeda;
            Console.WriteLine(calculo + " moeda(s) de R$ 0.25");
            resto = resto % moeda;

            moeda = 10;
            calculo = resto / moeda;
            Console.WriteLine(calculo + " moeda(s) de R$ 0.10");
            resto = resto % moeda;

            moeda = 5;
            calculo = resto / moeda;
            Console.WriteLine(calculo + " moeda(s) de R$ 0.05");
            resto = resto % moeda;

            Console.WriteLine(resto + " moeda(s) de R$ 0.01");

        }
    }
}
