using System;
using ProjetoXadrez.TabuleiroXad;

namespace ProjetoXadrez.JogoXadrez
{
    public class Rei : Peca
    {
        public Rei(Cor cor, Tabuleiro tab) : base(cor, tab)
        {

        }

        public override string ToString()
        {
            return "R";
        }
    }
}
