using System;
using Xadrez_Console.TabuleiroB;

namespace Xadrez_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Posicao p = new Posicao(3, 4);

            Tabuleiro tabuleiro = new Tabuleiro(8, 8);
            Tela.ImprimirTabuleiro(tabuleiro);
        }
    }
}
