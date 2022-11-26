using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Metodos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa = new Pessoa();
            pessoa.SetPosicao(20.5, 10.5);

            Console.Write("Posição: " + pessoa.GetPosicao());
            Console.ReadKey();
        }
    }
}
