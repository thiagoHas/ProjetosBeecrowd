using System;
using System.Globalization;

namespace ProjetosBeecrowd
{
    internal class _1015
    {
        static void Main(string[] args)
        {

            double distancia, x1, y1, x2, y2;

            string[] aa = (Console.ReadLine().Split(' '));
            x1 = double.Parse(aa[0], CultureInfo.InvariantCulture);
            y1 = double.Parse(aa[1], CultureInfo.InvariantCulture);

            string[] bb = (Console.ReadLine().Split(' '));
            x2 = double.Parse(bb[0], CultureInfo.InvariantCulture);
            y2 = double.Parse(bb[1], CultureInfo.InvariantCulture);

            distancia = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y2 - y1, 2));

            Console.WriteLine(distancia.ToString("F4", CultureInfo.InvariantCulture));

        }
    }
}
