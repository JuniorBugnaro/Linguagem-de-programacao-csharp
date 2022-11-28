using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 8. Faça um programa que conte de 1 até 1000 e a cada múltiplo de 3 exiba uma 
mensagem na frente: " – Número múltiplo de 3". */

            for (int i = 1; i <= 1000; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine(i +" Número múltiplo de 3");
                } else
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadKey();
        }
    }
}
