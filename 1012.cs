using System;
using System.Globalization;


namespace ProjetosBeecrowd
{
    internal class _1012
    {
        static void Main(string[] args)
        {

            double A, B, C, triangulo, circulo, trapezio, quadrado, retangulo, pi;
            pi = 3.14159;

            string[] aa = Console.ReadLine().Split(' ');
            A = double.Parse(aa[0], CultureInfo.InvariantCulture);
            B = double.Parse(aa[1], CultureInfo.InvariantCulture);
            C = double.Parse(aa[2], CultureInfo.InvariantCulture);

            triangulo = A * C / 2;
            circulo = pi * Math.Pow(C, 2);
            trapezio = (A + B) * C / 2;
            quadrado = B * B;
            retangulo = A * B;

            Console.WriteLine("TRIANGULO: " + triangulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("CIRCULO: " + circulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("TRAPEZIO: " + trapezio.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("QUADRADO: " + quadrado.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("RETANGULO: " + retangulo.ToString("F3", CultureInfo.InvariantCulture));

        }
    }
}
