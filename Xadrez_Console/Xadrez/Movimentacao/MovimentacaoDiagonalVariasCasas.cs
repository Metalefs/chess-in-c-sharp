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
            pos.DefinirValores(Posicao.Linha + 1, Posicao.Coluna + 1);
            while (Tabuleiro.PosicaoValida(pos) && PodeMover(pos))
            {
                try
                {
                    if (Tabuleiro.Peca(pos) != null && Tabuleiro.Peca(pos).Cor != Cor)
                    {
                        mat[pos.Linha, pos.Coluna] = true;
                        break;
                    }
                    else
                    {
                        mat[pos.Linha, pos.Coluna] = true;
                    }
                    pos.Linha = pos.Linha + 1;
                    pos.Coluna = pos.Coluna + 1;
                }
                catch (Exception) { continue; }
            }

            //so
            pos.DefinirValores(Posicao.Linha + 1, Posicao.Coluna - 1);
            while (Tabuleiro.PosicaoValida(pos) && PodeMover(pos))
            {
                try
                {
                    if (Tabuleiro.Peca(pos) != null && Tabuleiro.Peca(pos).Cor != Cor)
                    {
                        mat[pos.Linha, pos.Coluna] = true;
                        break;
                    }
                    else
                    {
                        mat[pos.Linha, pos.Coluna] = true;
                    }
                    pos.Linha = pos.Linha + 1;
                    pos.Coluna = pos.Coluna - 1;
                }
                catch (Exception) { continue; }
            }

            //ne
            pos.DefinirValores(Posicao.Linha - 1, Posicao.Coluna + 1);
            while (Tabuleiro.PosicaoValida(pos) && PodeMover(pos))
            {
                try
                {
                    if (Tabuleiro.Peca(pos) != null && Tabuleiro.Peca(pos).Cor != Cor)
                    {
                        mat[pos.Linha, pos.Coluna] = true;
                        break;
                    }
                    else
                    {
                        mat[pos.Linha, pos.Coluna] = true;
                    }
                    pos.Linha = pos.Linha - 1;
                    pos.Coluna = pos.Coluna + 1;
                }
                catch (Exception) { continue; }
            }

            //no
            pos.DefinirValores(Posicao.Linha - 1, Posicao.Coluna - 1);
            while (Tabuleiro.PosicaoValida(pos) && PodeMover(pos))
            {
                try
                {
                    if (Tabuleiro.Peca(pos) != null && Tabuleiro.Peca(pos).Cor != Cor)
                    {
                        mat[pos.Linha, pos.Coluna] = true;
                        break;
                    }
                    else
                    {
                        mat[pos.Linha, pos.Coluna] = true;
                    }
                    pos.Linha = pos.Linha - 1;
                    pos.Coluna = pos.Coluna - 1;
                }
                catch (Exception) { continue; }
            }

            return mat;
        }
    }
}
