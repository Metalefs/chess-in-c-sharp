using System;
using System.Collections.Generic;
using System.Text;
using Xadrez_Console.TabuleiroB;
using Xadrez_Console.Xadrez.Movimentacao;

namespace Xadrez_Console.Xadrez
{
    class Cavalo : MovimentacaoEmL
    {
        public Cavalo(Tabuleiro tabuleiro, Cor cor) : base(tabuleiro, cor)
        {
        }

        public override string ToString()
        {
            return "C";
        }

        public override bool PodeMover(Posicao pos)
        {
            Peca p = Tabuleiro.Peca(pos);
            return p == null || p.Cor != Cor;
        }
    }
}
