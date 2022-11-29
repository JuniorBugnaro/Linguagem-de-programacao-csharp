using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_10
{
    internal class Program
    {
        static void Main(string[] args) 
        {
            /* 10. Faça um programa que dada o nome e idade de um nadador, classifique-o em uma das
            seguintes categorias:
            - Infantil A = 5 a 7 anos
            - Infantil B = 8 a 11 anos
            - Juvenil A = 12 a 13 anos
            - Juvenil B = 14 a 17 anos
            - Adultos = Maiores de 18 anos */
         
            string nome;
            int idade;
            

            Console.WriteLine("Quantos nadadores irá informar ?");
            int quant = Convert.ToInt16(Console.ReadLine());

            for (int i = 1; i <= quant; i++)
            {
                Console.Write("Informe o nome do nadador: ");
                nome = Console.ReadLine();

                Console.Write("Informe a idade do nadador: ");
                idade = Convert.ToInt32(Console.ReadLine());
                if(idade < 5)
                {
                    Console.WriteLine("Idade invalida");            
                }
                if ((idade >= 5) && (idade <= 7))
                {
                    Console.WriteLine("O Nadador " + nome + " tem " + idade + " anos, por isso está na classe Infantil A");
                }
                else if ((idade >= 8) && (idade <= 11))
                {
                    Console.WriteLine("O Nadador " + nome + " tem " + idade + " anos, por isso está na classe Infantil B");
                }
                else if ((idade >= 12) && (idade <= 13))
                {
                    Console.WriteLine("O Nadador " + nome + " tem " + idade + " anos, por isso está na classe Juvenil A");
                }
                else if ((idade >= 14) && (idade <= 17))
                {
                    Console.WriteLine("O Nadador " + nome + " tem " + idade + " anos, por isso está na classe Juvenil B");
                }
                else if (idade >= 18)
                {
                    Console.WriteLine("O Nadador " + nome + " tem " + idade + " anos, por isso está na classe Adulto");
                }
            }
            Console.ReadKey();
        }  
    }
}
