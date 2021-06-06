using System;
using System.Collections.Generic;
using System.Text;

namespace Xadrez_Console.TabuleiroB
{
    class Peca
    {
        public Posicao Posicao { get; set; }
        public Cor Cor { get; protected set; }
        public int QtdMovimentos { get; private set; }
        public Tabuleiro Tabuleiro { get; private set; }

        public Peca(Tabuleiro tabuleiro, Cor cor)
        {
            Posicao = null;
            Cor = cor;
            Tabuleiro = tabuleiro;
            QtdMovimentos = 0;
        }
    }
}
