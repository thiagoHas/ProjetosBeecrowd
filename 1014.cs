using System;
using System.Globalization;

namespace ProjetosBeecrowd
{
    internal class _1014
    {
        static void Main(string[] args)
        {

            int X; double Y, calculo;

            X = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Y = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            calculo = X / Y;

            Console.WriteLine(calculo.ToString("F3", CultureInfo.InvariantCulture) + " km/l");

        }
    }
}
