﻿using System;

namespace ProjetosBeecrowd
{
    internal class _1037
    {
        static void Main(string[] args)
        {
            //Você deve fazer um programa que leia um valor qualquer e apresente uma mensagem
            //dizendo em qual dos seguintes intervalos ([0,25], (25,50], (50,75], (75,100]) este valor se encontra.
            double valor;

            valor = double.Parse(Console.ReadLine());

            if(valor >= 0 && valor <= 25.0000)
            {
                Console.WriteLine("Intervalo [0,25]");
            }
            else if(valor >= 25.00001 && valor <= 50.0000000)
            {
                Console.WriteLine("Intervalo (25,50]");
            }
            else if(valor >= 50.00000001 && valor <= 75.0000000)
            {
                Console.WriteLine("Intervalo (50,75]");
            }
            else if( valor >= 75.00000001 && valor <= 100.00000000)
            {
                Console.WriteLine("Intervalo (75,100}");
            }
            else { Console.WriteLine("Fora de intervalo"); }
        }
    }
}
