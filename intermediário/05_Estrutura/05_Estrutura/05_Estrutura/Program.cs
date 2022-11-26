using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Estrutura
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Polegada polegada = new Polegada(10);
            Console.WriteLine(polegada.GetPolegadaCentimero());
            Console.ReadKey();
        }
    }
}
