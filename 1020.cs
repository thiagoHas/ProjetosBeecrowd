using System;

namespace ProjetosBeecrowd
{
    internal class _1020
    {
        static void Main(string[] args)
        {

            int idade, resto, ano, mes, dia;

            idade = int.Parse(Console.ReadLine());

            ano = idade / 365;
            resto = idade % 365;
            mes = resto / 30;
            dia = resto % 30;

            Console.WriteLine(ano + " ano(s)");
            Console.WriteLine(mes + " mes(es)");
            Console.WriteLine(dia + " dia(s)");

        }
    }
}
