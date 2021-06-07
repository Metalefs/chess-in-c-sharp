using Xadrez_Console.Xadrez.Movimentacao;
using Xadrez_Console.TabuleiroB;

namespace Xadrez_Console.Xadrez
{
    class Rei : MovimentacaoLivreUmaCasa
    {
        public Rei(Tabuleiro tabuleiro, Cor cor) : base(tabuleiro,cor)
        {
        }

        public override string ToString()
        {
            return "R";
        }

        public override bool PodeMover(Posicao pos)
        {
            Peca p = Tabuleiro.Peca(pos);
            return p == null || p.Cor != Cor;
        }

        
    }
}
