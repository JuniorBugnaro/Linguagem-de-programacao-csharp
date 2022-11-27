using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //5. Escreva um programa que receba 4 números e apresente a soma dos números pares e depois dos números impares.

            float num = 0;
            float soma_im = 0;
            float soma_par = 0;

            Console.WriteLine("Escreva quatro numeros: ");
            for (int i = 1; i <= 4; i++)
            {
                Console.Write("numero " + i + ": ");
                float.TryParse(Console.ReadLine(), out num);
                if (num % 2 == 0)
                {
                    soma_par += num;
                } if (num % 2 == 1) 
                {
                    soma_im += num;
                }
            }
            Console.WriteLine("A soma dos numeros pares é: " + soma_par);
            Console.WriteLine("A soma dos numeros impares é: " + soma_im);

            Console.ReadKey();
        }
    }
}
