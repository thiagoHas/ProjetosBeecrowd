using System;

namespace ProjetosBeecrowd
{
    internal class _1114
    {
        static void Main(string[] args)
        {
            int senha = 2002;
            int x = int.Parse(Console.ReadLine());

            while (x != 2002)
            {
                Console.WriteLine("Senha Invalida");
                x = int.Parse(Console.ReadLine());            
            }
            Console.WriteLine("Acesso Permitido");
        }

    }
}
