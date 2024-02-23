using System;

namespace ProjetosBeecrowd
{
    internal class _1013
    {
        static void Main(string[] args)
        {

            string[] aa = Console.ReadLine().Split(' ');
            int a = int.Parse(aa[0]);
            int b = int.Parse(aa[1]);
            int c = int.Parse(aa[2]);

            int maiorAB = (a + b + Math.Abs(a - b)) / 2;

            int maior = (maiorAB + c + Math.Abs(maiorAB - c)) / 2;

            Console.WriteLine(maior + " eh o maior");

        }
    }
}
