using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 11. Faça um programa que calcule um plano de salário de um funcionário da Empresa XYZ, 
            onde deve ser informado a quantidade de anos de trabalho e o salário inicial. É regra 
            da empresa é aumentar o salário nos 3 primeiros anos em 50% a cada ano, nos demais 
            ela aumenta em 100% a cada ano trabalhado e a cada 10 anos ela dá um bônus de 
            10% de aumento */

            double salario;
            int ano;

            Console.Write("Quantos anos ele trabalha na empresa ? ");
            ano = Convert.ToInt32(Console.ReadLine());

            Console.Write("Qual o salario inicial do funcionário: ");
            double.TryParse(Console.ReadLine(), out salario);

           for (int i = 1; i <= 3; i++)
            {
                salario = salario + (salario * 0.50);
            }

           if (ano >= 4)
            {
                for(int i = 3; i <= ano; i++)
                {
                    salario += salario;
                }
            }
            if (ano % 10 == 0)
            {
                salario += (salario * 0.10);
            }


            Console.WriteLine("O salario do funcionario, que trabalha há " + ano + " anos é de R$" + salario.ToString("C"));

            Console.ReadKey();
        }
    }
}
