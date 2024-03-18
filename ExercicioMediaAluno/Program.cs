using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioMediaAluno
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // construa um algoritmo que receba 4 notas de um aluno, calcule a media e informe se esta aprovado ou não(corte 5)

            float nota1;
            float nota2;
            float nota3;
            float nota4;

            float media;



            Console.Write("Insira nota 1: ");
            nota1 = float.Parse(Console.ReadLine());

            Console.Write("Insira nota 2: ");
            nota2 = float.Parse(Console.ReadLine());

            Console.Write("Insira nota 3: ");
            nota3 = float.Parse(Console.ReadLine());

            Console.Write("Insira nota 4: ");
            nota4 = float.Parse(Console.ReadLine());

            media = (nota1 + nota2 + nota3 + nota4) / 4;

            if (media >= 5)
            {
                Console.WriteLine($"Parabens! Sua media foi {media}! Aprovado");
            }
            else
            {
                Console.WriteLine($"Sua media foi de {media}. Reprovado");
            }
            Console.ReadKey();
        }

    }
}
