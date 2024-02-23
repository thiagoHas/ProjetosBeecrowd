using System;
using System.Globalization;

namespace ProjetosBeecrowd
{
    internal class _1017
    {
        static void Main(string[] args)
        {

            int hora, velocidade;

            hora = int.Parse(Console.ReadLine());
            velocidade = int.Parse(Console.ReadLine());

            double calculo = (double)hora * velocidade / 12;

            Console.WriteLine(calculo.ToString("F3", CultureInfo.InvariantCulture));

        }
    }
}
