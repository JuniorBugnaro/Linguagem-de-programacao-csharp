using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //4. Faça um programa que gera a tabuada do número informado pelo usuário
            int numero;


            Console.WriteLine("Digite o numero que deseja gerar a tabuada: ");
            numero = Convert.ToInt32(Console.ReadLine());   

            for(int i = 0; i <= 10; i++)
            {
                int resultado = numero * i;
                Console.WriteLine(numero + "X" + i + "=" + resultado);
            }
            Console.ReadKey();
        }
    }
}
