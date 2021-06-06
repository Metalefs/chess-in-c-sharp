using System;
using System.Collections.Generic;
using System.Text;
using Xadrez_Console.TabuleiroB;

namespace Xadrez_Console.Xadrez
{
    class Rei : Peca
    {
        public Rei(Tabuleiro tabuleiro, Cor cor) : base(tabuleiro,cor)
        {
        }

        public override string ToString()
        {
            return "R";
        }
    }
}
