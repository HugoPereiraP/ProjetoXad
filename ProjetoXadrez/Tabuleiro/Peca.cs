
namespace ProjetoXadrez.TabuleiroXad
{

    public abstract class Peca
    {
        public Posicao posicao { get; set; }
        public Cor cor { get; protected set; }

        public int qtdMovimentos { get; protected set; }

        public Tabuleiro tab { get; protected set; }

        public Peca(Tabuleiro tab, Cor cor) 
        {
            this.posicao = null;
            this.cor = cor;
            this.qtdMovimentos = 0;
            this.tab = tab;
        }
        public void incrementarQtdMovimentos()
        {
            qtdMovimentos++;
        }

        public bool ExisteMovimentosPossiveis() {
            bool[,] mat = MovimentosPossiveis();
            for (int i = 0; i < tab.Linhas; i++)
            {
                for (int j = 0; j < tab.Colunas; j++)
                {
                    if (mat[i, j] == true)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public bool PodeMoverPara(Posicao pos) 
        {
            return MovimentosPossiveis()[pos.Linha, pos.Coluna] == true;

        }

        public abstract bool[,] MovimentosPossiveis();
            

              
        
    }
}
