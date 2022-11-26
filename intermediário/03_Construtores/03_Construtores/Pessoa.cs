using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Construtores
{
    internal class Pessoa
    {
        string Nome;
        String Sexo;
        DateTime DataNascimento;
        double PosicaoX, PosicaoY;

        public Pessoa(string nome, String sexo, DateTime dataNascimento, double X, double Y)
        {
            Nome = nome;
            Sexo = sexo;
            DataNascimento = dataNascimento;
            PosicaoX = X;
            PosicaoY = Y;
        }
    }
}
