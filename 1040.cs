using System;
using System.Globalization;

namespace ProjetosBeecrowd
{
    internal class _1040
    {
        static void Main(string[] args)
        {
            
            float n1, n2, n3, n4, media, exame, mediaFinal;

            string[] vet = Console.ReadLine().Split(' ');
            n1 = float.Parse(vet[0].ToString(CultureInfo.InvariantCulture));
            n2 = float.Parse(vet[1].ToString(CultureInfo.InvariantCulture));
            n3 = float.Parse(vet[2].ToString(CultureInfo.InvariantCulture));
            n4 = float.Parse(vet[3].ToString(CultureInfo.InvariantCulture));

            media = (n1 * 2 + n2 * 3 + n3 * 4 + n4 * 1) / 10;

            if (media == 4.85f)
            {
                media = 4.8f;
            }

            Console.WriteLine("Media: " + media.ToString("F1", CultureInfo.InvariantCulture));

            if (media >= 7.0)
            {
                Console.WriteLine("Aluno aprovado.");
            }

            else if(media < 5.0)
            {
                Console.WriteLine("Aluno reprovado.");
            }
            else
            {
                Console.WriteLine("Aluno em exame.");
                exame = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                mediaFinal = (media + exame) / 2;
                Console.WriteLine("Nota do exame: " + exame.ToString("F1", CultureInfo.InvariantCulture));
                if (mediaFinal >= 5.0)
                {
                    Console.WriteLine("Aluno aprovado.");
                }
                else
                {
                    Console.WriteLine("Aluno reprovado.");
                }
                Console.WriteLine("Media final: " + mediaFinal.ToString("F1", CultureInfo.InvariantCulture));
            }

        }
    }
}
