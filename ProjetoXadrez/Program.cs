using System;
using System.Dynamic;
using ProjetoXadrez.JogoXadrez;
using ProjetoXadrez.TabuleiroXad;

namespace ProjetoXadrez
{
    class Program   {
        public static void Main(string[] args)
        {
            try
            {
                Tabuleiro tab = new Tabuleiro(8, 8);

                tab.colocarPeca(new Torre(Cor.Preta, tab), new Posicao(0, 0));
                tab.colocarPeca(new Torre(Cor.Preta, tab), new Posicao(1, 3));
                tab.colocarPeca(new Rei(Cor.Branca, tab), new Posicao(4, 2));
                Tela.imprimitabuleiro(tab);

                Console.ReadLine();
            }
            catch (TabuleiroException te )
            {
                Console.WriteLine(te.Message);  
            }
         
        }
    }
}