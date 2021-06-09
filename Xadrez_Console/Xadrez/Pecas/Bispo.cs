using System;
using System.Collections.Generic;
using System.Text;
using Xadrez_Console.TabuleiroB;

namespace Xadrez_Console.Xadrez
{
    class Bispo : Movimentacao.MovimentacaoDiagonalVariasCasas
    {
        public Bispo(Tabuleiro tabuleiro, Cor cor) : base(tabuleiro, cor)
        {
        }

        public override bool PodeMover(Posicao pos)
        {
            Peca p = Tabuleiro.Peca(pos);
            return p == null || p.Cor != Cor;
        }

        public override string ToString()
        {
            return "B";
        }

    }
}
