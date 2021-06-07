using Xadrez_Console.TabuleiroB;
using Xadrez_Console.Xadrez.Movimentacao;

namespace Xadrez_Console.Xadrez
{
    class Torre : MovimentacaoCruzVariasCasas
    {
        public Torre(Tabuleiro tabuleiro, Cor cor) : base(tabuleiro, cor)
        {
        }

        public override string ToString()
        {
            return "T";
        }

        public override bool PodeMover(Posicao pos)
        {
            Peca p = Tabuleiro.Peca(pos);
            return p == null || p.Cor != Cor;
        }        
    }
}
