using System;
using ProjetoXadrez.TabuleiroXad;

namespace ProjetoXadrez.JogoXadrez
{
    public class Peao : Peca
    {
        private PartidaDeXadrez partida;

        public Peao(Tabuleiro tab, Cor cor, PartidaDeXadrez partida) : base(tab, cor)
        {
            this.partida = partida;
        }

        public override string ToString()
        {
            return "P";
        }

        private bool ExisteInimigo(Posicao pos)
        {
            Peca p = tab.peca(pos);
            return p != null && p.cor != cor;
        }

        private bool Livre(Posicao pos)
        {
            return tab.peca(pos) == null;
        }

        public override bool[,] MovimentosPossiveis()
        {
            bool[,] mat = new bool[tab.Linhas, tab.Colunas];

            Posicao pos = new Posicao(0, 0);

            if (cor == Cor.Branca)
            {
                // 1 casa acima
                pos.DefinirValores(posicao.Linha - 1, posicao.Coluna);
                if (tab.posicaoValida(pos) && Livre(pos))
                {
                    mat[pos.Linha, pos.Coluna] = true;
                }

                // 2 casas acima (apenas no primeiro movimento)
                Posicao p2 = new Posicao(posicao.Linha - 2, posicao.Coluna);
                if (tab.posicaoValida(p2) && Livre(p2) && Livre(pos) && qtdMovimentos == 0)
                {
                    mat[p2.Linha, p2.Coluna] = true;
                }

                // Captura diagonal esquerda
                pos.DefinirValores(posicao.Linha - 1, posicao.Coluna - 1);
                if (tab.posicaoValida(pos) && ExisteInimigo(pos))
                {
                    mat[pos.Linha, pos.Coluna] = true;
                }

                // Captura diagonal direita
                pos.DefinirValores(posicao.Linha - 1, posicao.Coluna + 1);
                if (tab.posicaoValida(pos) && ExisteInimigo(pos))
                {
                    mat[pos.Linha, pos.Coluna] = true;
                }

                // #jogadaespecial En Passant (Brancas)
                if (posicao.Linha == 3)
                {
                    Posicao esquerda = new Posicao(posicao.Linha, posicao.Coluna - 1);
                    if (tab.posicaoValida(esquerda) && ExisteInimigo(esquerda) && tab.peca(esquerda) == partida.VulneravelEnPassant)
                    {
                        mat[esquerda.Linha - 1, esquerda.Coluna] = true;
                    }

                    Posicao direita = new Posicao(posicao.Linha, posicao.Coluna + 1);
                    if (tab.posicaoValida(direita) && ExisteInimigo(direita) && tab.peca(direita) == partida.VulneravelEnPassant)
                    {
                        mat[direita.Linha - 1, direita.Coluna] = true;
                    }
                }
            }
            else
            {
                // 1 casa abaixo
                pos.DefinirValores(posicao.Linha + 1, posicao.Coluna);
                if (tab.posicaoValida(pos) && Livre(pos))
                {
                    mat[pos.Linha, pos.Coluna] = true;
                }

                // 2 casas abaixo (apenas no primeiro movimento)
                Posicao p2 = new Posicao(posicao.Linha + 2, posicao.Coluna);
                if (tab.posicaoValida(p2) && Livre(p2) && Livre(pos) && qtdMovimentos == 0)
                {
                    mat[p2.Linha, p2.Coluna] = true;
                }

                // Captura diagonal esquerda
                pos.DefinirValores(posicao.Linha + 1, posicao.Coluna - 1);
                if (tab.posicaoValida(pos) && ExisteInimigo(pos))
                {
                    mat[pos.Linha, pos.Coluna] = true;
                }

                // Captura diagonal direita
                pos.DefinirValores(posicao.Linha + 1, posicao.Coluna + 1);
                if (tab.posicaoValida(pos) && ExisteInimigo(pos))
                {
                    mat[pos.Linha, pos.Coluna] = true;
                }

                // #jogadaespecial En Passant (Pretas)
                if (posicao.Linha == 4)
                {
                    Posicao esquerda = new Posicao(posicao.Linha, posicao.Coluna - 1);
                    if (tab.posicaoValida(esquerda) && ExisteInimigo(esquerda) && tab.peca(esquerda) == partida.VulneravelEnPassant)
                    {
                        mat[esquerda.Linha + 1, esquerda.Coluna] = true;
                    }

                    Posicao direita = new Posicao(posicao.Linha, posicao.Coluna + 1);
                    if (tab.posicaoValida(direita) && ExisteInimigo(direita) && tab.peca(direita) == partida.VulneravelEnPassant)
                    {
                        mat[direita.Linha + 1, direita.Coluna] = true;
                    }
                }
            }

            return mat;
        }
    }
}