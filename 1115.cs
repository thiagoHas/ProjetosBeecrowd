using System;

namespace ProjetosBeecrowd
{
    internal class _1115
    {
        static void Main(string[] args)
        {
            int x, y;

            string[] vet = Console.ReadLine().Split(' ');
            x = int.Parse(vet[0]);
            y = int.Parse(vet[1]);

            while(x != 0 $$ y != 0)
            {
                if(x > 0) { 
                    if(y > 0)
                    {
                        Console.WriteLine("Primeiro");
                    }
                    else
                    {
                        Console.WriteLine("Quarto");
                    }              
                }
                else
                {
                    if (y > 0)
                    {
                        Console.WriteLine("Segundo");
                    }
                    else
                    {
                        Console.WriteLine("Terceiro");
                    }
                }
                vet = Console.ReadLine().Split(' ');
                x = int.Parse(vet[0]);
                y = int.Parse(vet[1]);
            }
        }
    }
}
