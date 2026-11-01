using System;
using ProjetoXadrez.TabuleiroXad;

namespace ProjetoXadrez.JogoXadrez
{
    public class Cavalo : Peca
    {
        public Cavalo(Tabuleiro tab, Cor cor) : base(tab, cor)
        {
        }

        public override string ToString()
        {
            return "C";
        }

        private bool PodeMover(Posicao pos)
        {
            Peca p = tab.peca(pos);
            return p == null || p.cor != cor;
        }

        public override bool[,] MovimentosPossiveis()
        {
            bool[,] mat = new bool[tab.Linhas, tab.Colunas];

            Posicao pos = new Posicao(0, 0);

            // 1 UP, 2 LEFT
            pos.DefinirValores(posicao.Linha - 1, posicao.Coluna - 2);
            if (tab.posicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
            }

            // 2 UP, 1 LEFT
            pos.DefinirValores(posicao.Linha - 2, posicao.Coluna - 1);
            if (tab.posicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
            }

            // 2 UP, 1 RIGHT
            pos.DefinirValores(posicao.Linha - 2, posicao.Coluna + 1);
            if (tab.posicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
            }

            // 1 UP, 2 RIGHT
            pos.DefinirValores(posicao.Linha - 1, posicao.Coluna + 2);
            if (tab.posicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
            }

            // 1 DOWN, 2 RIGHT
            pos.DefinirValores(posicao.Linha + 1, posicao.Coluna + 2);
            if (tab.posicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
            }

            // 2 DOWN, 1 RIGHT
            pos.DefinirValores(posicao.Linha + 2, posicao.Coluna + 1);
            if (tab.posicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
            }

            // 2 DOWN, 1 LEFT
            pos.DefinirValores(posicao.Linha + 2, posicao.Coluna - 1);
            if (tab.posicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
            }

            // 1 DOWN, 2 LEFT
            pos.DefinirValores(posicao.Linha + 1, posicao.Coluna - 2);
            if (tab.posicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
            }

            return mat;
        }
    }
}