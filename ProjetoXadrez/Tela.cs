using System;
using ProjetoXadrez.JogoXadrez;
using ProjetoXadrez.TabuleiroXad;
namespace ProjetoXadrez;

public  class Tela
{
    public static void imprimitabuleiro(Tabuleiro tab)
    {
        for(int i = 0; i < tab.Linhas; i++)
        {
            Console.Write( 8-i + " ");
            for (int j = 0; j < tab.Colunas; j++)
            {
              
                imprimirPeca(tab.peca(i, j));
                Console.Write(" ");

                
                    
            }
            Console.WriteLine();
        }
        Console.WriteLine( "  a  b  c  d  e  f  g  h ");
    }

    public static void ImrpmimirPartida(PartidaDeXadrez partida) {
        imprimitabuleiro(partida.tab);
        ImrpimirPecasCapturadas(partida);
        Console.WriteLine();
        Console.WriteLine("Turno : " + partida.Turno);
        Console.WriteLine("Aguardando jogada " + partida.JogadorAtual);
    }

    public static void ImrpimirPecasCapturadas(PartidaDeXadrez partida) {
        Console.WriteLine("Peças capturdas : ");
        Console.Write("Brancas : ");
        ImprimirConjunto(partida.pecasCapturadas(Cor.Branca)); 
        Console.WriteLine();
        Console.Write("Pretas : ");
        ConsoleColor aux = Console.ForegroundColor;
        Console.ForegroundColor = ConsoleColor.Yellow;
        ImprimirConjunto(partida.pecasCapturadas(Cor.Preta));
         Console.ForegroundColor = aux;
        Console.WriteLine();

    }

    public static void ImprimirConjunto(HashSet<Peca> conjunto) {
        Console.Write("[");
        foreach (Peca x in conjunto) {
            Console.Write(x + " ");
            
            }
        Console.Write("  ] ");
    }   
   
    public static void imprimitabuleiro(Tabuleiro tab, bool[,] PosicaoPossiveis)
    {
        ConsoleColor FundoOriginal = Console.BackgroundColor;
        ConsoleColor FundoAlterado = ConsoleColor.DarkGray;
        for (int i = 0; i < tab.Linhas; i++)
        {
            Console.Write(8 - i + " ");
            for (int j = 0; j < tab.Colunas; j++)
            {
                if (PosicaoPossiveis[i, j])
                {
                    Console.BackgroundColor = FundoAlterado;

                }
                else { 
                    Console.BackgroundColor = FundoOriginal; 
                }
                    imprimirPeca(tab.peca(i, j));
                    Console.BackgroundColor = FundoOriginal;
            }
            Console.WriteLine();
        }
        Console.WriteLine("  a b c d e f g h ");
        Console.BackgroundColor = FundoOriginal;
    }

    public static PosicaoXadrez LerPosicaoXadrez() {
    
        string s = Console.ReadLine();
        char coluna = s[0];
        int linha = int.Parse(s[1] + " ");
        return new PosicaoXadrez(coluna, linha);

    }
    public static void imprimirPeca(Peca peca)
    {

        if (peca == null)
        {
            Console.Write("- ");
        }
        else
        {
            if (peca.cor == Cor.Branca)
            {
                Console.Write(peca);
            }
            else
            {
                ConsoleColor aux = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(peca);
                Console.ForegroundColor = aux;
            }
            Console.Write(" ");
        }
    }
}
