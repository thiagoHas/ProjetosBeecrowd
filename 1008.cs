using System;
using System.Globalization;

namespace ProjetosBeecrowd
{
    internal class _1008
    {
        static void Main(string[] args)
        {

            int numero, horasTrabalhada;
            double salario;

            numero = int.Parse(Console.ReadLine());
            horasTrabalhada = int.Parse(Console.ReadLine());
            salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            salario = salario * horasTrabalhada; ;

            Console.WriteLine("NUMBER = " + numero);
            Console.WriteLine("SALARY = U$ " + salario.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
