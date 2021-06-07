﻿using System;
using Xadrez_Console.TabuleiroB;
using Xadrez_Console.Xadrez;

namespace Xadrez_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Tabuleiro tabuleiro = new Tabuleiro(8, 8);

                tabuleiro.ColocarPeca(new Torre(tabuleiro, Cor.Preta), new Posicao(0, 1));
                tabuleiro.ColocarPeca(new Torre(tabuleiro, Cor.Preta), new Posicao(9, 3));
                tabuleiro.ColocarPeca(new Rei(tabuleiro, Cor.Branca), new Posicao(1, 4));
                
                Tela.ImprimirTabuleiro(tabuleiro);
            }
            catch (TabuleiroException e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}
