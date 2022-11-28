using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 7. Escreva um programa que receba uma quantidade definida pelo usuário de números e 
            pegue o maior e o menor número informado e apresente na tela */

            float num = 0;
            
            Console.WriteLine("Quantos numeros deseja informar ?");
            int quant = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o 1 numero: ");
            float.TryParse(Console.ReadLine(), out num);

            float maior = num;
            float menor = num;

            for (int i = 2; i <= quant; i++)
            {
                Console.Write("Digite o " + i + " numero: ");
                float.TryParse(Console.ReadLine(), out num);
                if (num > maior)
                {
                    maior = num;
                }
                else if (num < menor)
                {
                    menor = num;
                }
            }
            Console.WriteLine("O maior numero é: " + maior);
            Console.WriteLine("O menor numero é: " + menor);
            Console.ReadKey();
        }
    }
}
