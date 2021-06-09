using System;
using System.Collections.Generic;
using System.Text;
using Xadrez_Console.TabuleiroB;

namespace Xadrez_Console.Xadrez.Movimentacao
{
    abstract class MovimentacaoLivreVariasCasas : Peca
    {
        public MovimentacaoLivreVariasCasas(Tabuleiro tabuleiro, Cor cor) : base(tabuleiro, cor)
        {
        }
        public abstract bool PodeMover(Posicao pos);

        public override bool[,] MovimentosPossiveis()
        {
            bool[,] mat = new bool[Tabuleiro.Linhas, Tabuleiro.Colunas];

            Posicao pos = new Posicao(0, 0);

            //acima
            pos.DefinirValores(Posicao.Linha - 1, Posicao.Coluna);
            while (Tabuleiro.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
                if (Tabuleiro.Peca(pos) != null && Tabuleiro.Peca(pos).Cor != Cor)
                {
                    break;
                }
                pos.Linha = pos.Linha - 1;
            }
            //abaixo
            pos.DefinirValores(Posicao.Linha + 1, Posicao.Coluna);
            while (Tabuleiro.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
                if (Tabuleiro.Peca(pos) != null && Tabuleiro.Peca(pos).Cor != Cor)
                {
                    break;
                }
                pos.Linha = pos.Linha + 1;
            }
            //esquerda
            pos.DefinirValores(Posicao.Linha, Posicao.Coluna - 1);
            while (Tabuleiro.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
                if (Tabuleiro.Peca(pos) != null && Tabuleiro.Peca(pos).Cor != Cor)
                {
                    break;
                }
                pos.Coluna = pos.Coluna - 1;
            }
            //direita
            pos.DefinirValores(Posicao.Linha, Posicao.Coluna + 1);
            while (Tabuleiro.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
                if (Tabuleiro.Peca(pos) != null && Tabuleiro.Peca(pos).Cor != Cor)
                {
                    break;
                }
                pos.Coluna = pos.Coluna + 1;
            }
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
