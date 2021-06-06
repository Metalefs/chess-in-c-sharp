using System;
using System.Collections.Generic;
using System.Text;
using Xadrez_Console.TabuleiroB;

namespace Xadrez_Console
{
    class Tela
    {
        public static void ImprimirTabuleiro(Tabuleiro tabuleiro)
        {
            for (int i = 0; i < tabuleiro.Linhas; i++)
            {
                for (int j = 0; j < tabuleiro.Colunas; j++)
                {
                    Peca peca = tabuleiro.Peca(i, j);
                    Console.Write(peca == null ? "- " : peca + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
