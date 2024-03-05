using System;

namespace ProjetosBeecrowd
{
    internal class _1046
    {
        static void Main(string[] args)
        {

            int horaInicial, horaFinal;

            string[] vet = Console.ReadLine().Split(' ');
            horaInicial = int.Parse(vet[0]);
            horaFinal = int.Parse(vet[1]);

            int duracao;
            if(horaInicial < horaFinal)
            {
                duracao = horaFinal - horaInicial;
            }
            else
            {
                duracao = 24 - horaInicial + horaFinal;
            }

            Console.WriteLine("O JOGO DUROU "+duracao+" HORA(S)");

        }
    }
}
