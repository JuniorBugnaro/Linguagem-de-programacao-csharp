using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Metodos
{
    internal class Pessoa
    {
        public string Nome;
        public string Sexo;
        public DateTime DataNascimento;
        public double PosicaoX, PosicaoY;

        public string GetPosicao()
        {
            return PosicaoX + ", " + PosicaoY;
        }

        public void SetPosicao(double X, double Y)
        {
            PosicaoX = X;
            PosicaoY = Y;
        }
    }
}
