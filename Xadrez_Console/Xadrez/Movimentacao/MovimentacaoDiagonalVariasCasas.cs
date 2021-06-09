using System;
using System.Collections.Generic;
using System.Text;
using Xadrez_Console.TabuleiroB;

namespace Xadrez_Console.Xadrez.Movimentacao
{
    abstract class MovimentacaoDiagonalVariasCasas : Peca
    {
        public MovimentacaoDiagonalVariasCasas(Tabuleiro tabuleiro, Cor cor) : base(tabuleiro, cor)
        {
        }
        public abstract bool PodeMover(Posicao pos);
        public override bool[,] MovimentosPossiveis()
        {
            bool[,] mat = new bool[Tabuleiro.Linhas, Tabuleiro.Colunas];

            Posicao pos = new Posicao(0, 0);

            //se
            while (Tabuleiro.PosicaoValida(pos) && PodeMover(pos))
            {
                pos.DefinirValores(Posicao.Linha + 1, Posicao.Coluna + 1);
                if (Tabuleiro.Peca(pos) != null && Tabuleiro.Peca(pos).Cor != Cor)
                {
                    break;
                }
                pos.Linha = pos.Linha + 1;
                pos.Coluna = pos.Coluna + 1;
            }

            //so
            while (Tabuleiro.PosicaoValida(pos) && PodeMover(pos))
            {
                pos.DefinirValores(Posicao.Linha + 1, Posicao.Coluna - 1);
                if (Tabuleiro.Peca(pos) != null && Tabuleiro.Peca(pos).Cor != Cor)
                {
                    break;
                }
                pos.Linha = pos.Linha + 1;
                pos.Coluna = pos.Coluna - 1;
            }

            //ne
            while (Tabuleiro.PosicaoValida(pos) && PodeMover(pos))
            {
                pos.DefinirValores(Posicao.Linha - 1, Posicao.Coluna + 1);
                if (Tabuleiro.Peca(pos) != null && Tabuleiro.Peca(pos).Cor != Cor)
                {
                    break;
                }
                pos.Linha = pos.Linha - 1;
                pos.Coluna = pos.Coluna + 1;
            }

            //no
            while (Tabuleiro.PosicaoValida(pos) && PodeMover(pos))
            {
                pos.DefinirValores(Posicao.Linha - 1, Posicao.Coluna - 1);
                if (Tabuleiro.Peca(pos) != null && Tabuleiro.Peca(pos).Cor != Cor)
                {
                    break;
                }
                pos.Linha = pos.Linha - 1;
                pos.Coluna = pos.Coluna - 1;
            }

            return mat;
        }
    }
}
