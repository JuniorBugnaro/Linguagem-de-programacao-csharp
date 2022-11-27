using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_6
{
    internal class Program
    {
        static void Main(string[] args)
        {/* 6. Escreva um programa que calcule a nota de cada aluno e a média da turma. O 
        programa deve receber o nome do aluno e a nota de cada bimestre (4 notas), ao 
        informar no nome do aluno o valor “finalizar” o programa deve realizar os cálculos da 
        média e apresentar na tela */

            float nota;
            float soma = 0;
            string aluno;
            float mediaaluno = 0;
            float mediaclasse = 0;
            

            Console.WriteLine("Quantidade de alunos na classe: ");
            float quant = 0;
            float.TryParse(Console.ReadLine(), out quant);
            
            for(int i = 1; i <= quant; i++)
            {
                Console.WriteLine("Nome do aluno: ");
                aluno = Console.ReadLine();

                for (int j = 1; j <= 4; j++)
                {
                    Console.WriteLine("Qual a nota do " + aluno + " No " + j + " Bimestre");
                    float.TryParse(Console.ReadLine(), out nota);

                    mediaaluno = nota / 4;
                    soma += nota;
                    mediaclasse = soma / quant;
                
                }
            }
            
            Console.WriteLine("A soma das notas da classe é: " + soma);
            Console.WriteLine("A media das notas da classe é: " + mediaclasse);

            Console.ReadKey();
        }   
    }
}
