using System;
using System.Globalization;

namespace ProjetosBeecrowd
{
    internal class _1011
    {
        static void Main(string[] args)
        {

            double soma;

            string[] aa = Console.ReadLine().Split(' ');
            int cPeca = int.Parse(aa[0]);
            int nPeca = int.Parse(aa[1]);
            double vPeca = double.Parse(aa[2], CultureInfo.InvariantCulture);

            string[] bb = Console.ReadLine().Split(' ');
            int cPeca2 = int.Parse(bb[0]);
            int nPeca2 = int.Parse(bb[1]);
            double vPeca2 = double.Parse(bb[2], CultureInfo.InvariantCulture);

            soma = (vPeca * nPeca) + (vPeca2 * nPeca2);

            Console.WriteLine("VALOR A PAGAR: R$ " + soma.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
