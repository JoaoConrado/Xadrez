using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using xadrez_console.tabuleiro;
namespace xadrez
{
    internal class PosicaoXadrez
    {
        public char Coluna { get; set; }
        public int Linha { get; set; }

        public PosicaoXadrez(char coluna, int linhas)
        {
            this.Coluna = coluna;
            this.Linha = linhas;
        }



        public Posicao toPosicao()
        {
            return new Posicao(8 - Linha, Coluna - 'A');
        }
        public override string ToString()
        {
            return "" + Coluna + Linha;
        }


    }
}
