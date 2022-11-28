using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 9. Faça um programa de conversão de base numérica. O programa deverá apresentar 
         tela de entrada com as seguintes opções:
         1 – Adição
         2 – Subtração
         3 – Multiplicação
         4 – Divisão
         Informe a opção:
         A partir da opção escolhida, o programa deverá solicitar para que o usuário digite dois 
         números. Em seguida, o programa deve exibir o resultado da opção indicada pelo 
         usuário e perguntar ao usuário se ele deseja voltar ao menu principal. Caso a resposta 
         seja “S” ou “s”, deverá voltar ao menu, caso contrário deverá encerrar o programa. */
            run();
        }
            static void run()
            {



                float resultado;

                Console.WriteLine("Escolha uma das seguintes opcções: ");
                Console.WriteLine(" 1 - Adição \n 2 - Subtração  \n 3 - Multiplicação \n 4 - Divisão ");
                string valor = Console.ReadLine();
                Console.Write("Informe o 1º numero: ");
                int num1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("informe o 2º numero: ");
                int num2 = Convert.ToInt32(Console.ReadLine());

                switch (valor)
                {
                    case "1":
                        resultado = num1 + num2;
                        Console.WriteLine(num1 + " + " + num2 + " = " + resultado);
                        break;
                    case "2":
                        resultado = num1 - num2;
                        Console.WriteLine(num1 + " - " + num2 + " = " + resultado);
                        break;
                    case "3":
                        resultado = num1 * num2;
                        Console.WriteLine(num1 + " x " + num2 + " = " + resultado);
                        break;
                    case "4":
                        resultado = num1 / num2;
                        Console.WriteLine(num1 + " / " + num2 + " = " + resultado);
                        break;
                }

                Console.WriteLine(" Deseja voltar ao menu principal ? \n Digite s para sim e n para não");
                string voltar = Console.ReadLine();

                if (voltar == "s")
                {
                run();
                }

                Console.ReadKey();
            }
        
    }
}
