﻿using TreinaTudoXadrez.tabuleiro;

namespace TreinaTudoXadrez.xadrez
{
    class Torre : Peca
    {
        public Torre(Tabuleiro tab, Cor cor) : base (tab, cor)
        {

        }
        public override string ToString()
        {
            return "T";
        }
    }
}
