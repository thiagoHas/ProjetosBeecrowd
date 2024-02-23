using System;
using System.Globalization;

namespace ProjetosBeecrowd
{
    internal class _1009
    {
        static void Main(string[] args)
        {

            string nome;
            double sFixo, mVendas, comissao, total;

            nome = Console.ReadLine();
            sFixo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            mVendas = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            comissao = mVendas * 0.15;
            total = sFixo + comissao;

            Console.WriteLine("TOTAL = R$ " + total.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
