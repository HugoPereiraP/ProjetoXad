using System;
using System.Dynamic;
using ProjetoXadrez.JogoXadrez;
using ProjetoXadrez.TabuleiroXad;

namespace ProjetoXadrez
{
    class Program   {
        public static void Main(string[] args)
        {
            Tabuleiro tab = new Tabuleiro(8, 8);
            tab.colocarPeca(new Torre(Cor.Preta,tab), new Posicao(0, 0));
            tab.colocarPeca(new Torre(Cor.Preta, tab), new Posicao(1, 3));
            tab.colocarPeca(new Rei(Cor.Preta, tab), new Posicao(2, 4));
            Tela.imprimitabuleiro(tab);

            Console.ReadLine(); 
        }
    }
}