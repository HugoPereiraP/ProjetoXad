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
                PartidaDeXadrez partida = new PartidaDeXadrez();
                while (!partida.terminada)
                {
                    try { 
                    Console.Clear();
                        Tela.ImrpmimirPartida(partida);

                    Console.Write("digite a posicao de origem : ");
                    Posicao origem = Tela.LerPosicaoXadrez().toPosicao();
                    partida.ValidarPosicaoDeOrigem(origem);

                    bool[,] posicaoPossiveis = partida.tab.peca(origem).MovimentosPossiveis();

                    Console.Clear();
                    Tela.imprimitabuleiro(partida.tab,posicaoPossiveis);


                    Console.WriteLine();
                    Console.Write("digite a posição de destino : ");
                    Posicao destino = Tela.LerPosicaoXadrez().toPosicao();
                        partida.ValidarPosicaoDeDestino(origem, destino);
                    partida.RealizaJogada(origem, destino);  

                    }
                    catch (TabuleiroException te) 
                    { 
                        Console.WriteLine(te.Message);
                        Console.ReadLine();

                    
                    }
                }


                Tela.imprimitabuleiro(partida.tab);
            }
            
            catch (TabuleiroException te )
            {
                Console.WriteLine(te.Message);  
            }
         
        }
    }
}