using System;
using ProjetoXadrez.TabuleiroXad;

namespace ProjetoXadrez.JogoXadrez
{
    public class Dama : Peca
    {
        public Dama(Tabuleiro tab, Cor cor) : base(tab, cor)
        {
        }

        public override string ToString()
        {
            return "D";
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

            // acima
            pos.DefinirValores(posicao.Linha - 1, posicao.Coluna);
            while (tab.posicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
                if (tab.peca(pos) != null && tab.peca(pos).cor != cor)
                {
                    break;
                }
                pos.DefinirValores(pos.Linha - 1, pos.Coluna);
            }

            // abaixo
            pos.DefinirValores(posicao.Linha + 1, posicao.Coluna);
            while (tab.posicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
                if (tab.peca(pos) != null && tab.peca(pos).cor != cor)
                {
                    break;
                }
                pos.DefinirValores(pos.Linha + 1, pos.Coluna);
            }

            // direita
            pos.DefinirValores(posicao.Linha, posicao.Coluna + 1);
            while (tab.posicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
                if (tab.peca(pos) != null && tab.peca(pos).cor != cor)
                {
                    break;
                }
                pos.DefinirValores(pos.Linha, pos.Coluna + 1);
            }

            // esquerda
            pos.DefinirValores(posicao.Linha, posicao.Coluna - 1);
            while (tab.posicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
                if (tab.peca(pos) != null && tab.peca(pos).cor != cor)
                {
                    break;
                }
                pos.DefinirValores(pos.Linha, pos.Coluna - 1);
            }

            // NO (noroeste)
            pos.DefinirValores(posicao.Linha - 1, posicao.Coluna - 1);
            while (tab.posicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
                if (tab.peca(pos) != null && tab.peca(pos).cor != cor)
                {
                    break;
                }
                pos.DefinirValores(pos.Linha - 1, pos.Coluna - 1);
            }

            // NE (nordeste)
            pos.DefinirValores(posicao.Linha - 1, posicao.Coluna + 1);
            while (tab.posicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
                if (tab.peca(pos) != null && tab.peca(pos).cor != cor)
                {
                    break;
                }
                pos.DefinirValores(pos.Linha - 1, pos.Coluna + 1);
            }

            // SE (sudeste)
            pos.DefinirValores(posicao.Linha + 1, posicao.Coluna + 1);
            while (tab.posicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
                if (tab.peca(pos) != null && tab.peca(pos).cor != cor)
                {
                    break;
                }
                pos.DefinirValores(pos.Linha + 1, pos.Coluna + 1);
            }

            // SO (sudoeste)
            pos.DefinirValores(posicao.Linha + 1, posicao.Coluna - 1);
            while (tab.posicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
                if (tab.peca(pos) != null && tab.peca(pos).cor != cor)
                {
                    break;
                }
                pos.DefinirValores(pos.Linha + 1, pos.Coluna - 1);
            }

            return mat;
        }
    }
}