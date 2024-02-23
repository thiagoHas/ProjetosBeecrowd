using System;
using System.Globalization;


namespace ProjetosBeecrowd
{
    internal class _1038
    {
        static void Main(string[] args)
        {

            int quantidade, codigo;
            double total;

            string[] vet = Console.ReadLine().Split(' ');
            codigo = int.Parse(vet[0]);
            quantidade = int.Parse(vet[1]);

            if (codigo == 1)
            {
                total = quantidade * 4.00;
            }
            else if (codigo == 2)
            {
                total = quantidade * 4.50;
            }
            else if (codigo == 3)
            {
                total = quantidade * 5.00;
            }
            else if (codigo == 4)
            {
                total = quantidade * 2.00;
            }
            else
            {
                total = quantidade * 1.50;
            }

            Console.WriteLine("Total: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
