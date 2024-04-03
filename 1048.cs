using System;
using System.Globalization;

namespace ProjetosBeecrowd
{
    internal class _1048
    {
        static void Main(string[] args)
        {

            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double calculo, novoSalario, reajuste, diferenca;
            if(salario <= 400.00 )
            {
                reajuste = 15.0;
                calculo = salario * (reajuste / 100);
                novoSalario = salario + calculo;
                diferenca = novoSalario - salario;

            }
            else if(salario >= 400.01 && salario <= 800.00)
            {
                reajuste = 12.0;
                calculo = salario * (reajuste / 100);
                novoSalario = salario + calculo;
                diferenca = novoSalario - salario;

            }
            else if(salario >= 800.01 && salario <= 1200.00)
            {
                reajuste = 10.0;
                calculo = salario * (reajuste / 100);
                novoSalario = salario + calculo;
                diferenca = novoSalario - salario;

            }
            else if(salario >= 1200.01 && salario <= 2000.00)
            {
                reajuste = 7.0;
                calculo = salario * (reajuste / 100);
                novoSalario = salario + calculo;
                diferenca = novoSalario - salario;
            }
            else
            {
                reajuste = 4.0;
                calculo = salario * (reajuste / 100);
                novoSalario = salario + calculo;
                diferenca = novoSalario - salario;
            }

            Console.WriteLine("Novo salario: "+novoSalario.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Reajuste ganho: "+diferenca.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Em percentual: " + reajuste + " %");

        }
    }
}
