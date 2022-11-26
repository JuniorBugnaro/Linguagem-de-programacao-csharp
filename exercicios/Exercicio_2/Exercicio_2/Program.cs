using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*2. Escreva um programa que leia:
            - A quantidade de números que o usuário deseja informar.
            - Leia cada número e informe a média aritmética e a soma deles.*/
            
            float media = 0;
            float soma = 0;


            Console.WriteLine("Quantos numeros deseja informar ?");
            int quant = Convert.ToInt32(Console.ReadLine());

                for(int i = 1; i <= quant; i++)
            {
                Console.WriteLine("Informe um numero " + i);
                float num = 0;
                float.TryParse(Console.ReadLine(), out num);
                soma += num;
            }

            media = soma / quant;

            Console.WriteLine("A soma dos numero é igual a: " + soma);
            Console.WriteLine("A media dos numeros é igual a: " + media);
           

            
            Console.ReadKey();


        }
    }
}
