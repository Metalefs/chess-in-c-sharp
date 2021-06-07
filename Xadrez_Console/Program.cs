using System;
using Xadrez_Console.TabuleiroB;
using Xadrez_Console.Xadrez;

namespace Xadrez_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            PosicaoXadrez posicaoXadrez = new PosicaoXadrez('a', 1);
            PosicaoXadrez posicaoXadrez2 = new PosicaoXadrez('c', 7);
            Console.WriteLine(posicaoXadrez);
            Console.WriteLine(posicaoXadrez.ToPosicao());
            Console.WriteLine(posicaoXadrez2);
            Console.WriteLine(posicaoXadrez2.ToPosicao());
        }
    }
}
