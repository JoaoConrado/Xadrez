using xadrez_console;
using tabuleiro;
using xadrez;


// See https://aka.ms/new-console-template for more information
try
{
    PartidaDeXadrez partida = new PartidaDeXadrez();
    while (!partida.terminada)
    {
        Console.Clear();

        Tela.imprimirTabuleiro(partida.tab);


        Console.WriteLine();
        Console.Write("Origem:");
        Posicao origem = Tela.lerPosicaoXadrez().toPosicao();

        bool[,] posicoesPossiveis = partida.tab.peca(origem).MovimentoPossiveis();

        Console.Clear();
        Tela.imprimirTabuleiro(partida.tab, posicoesPossiveis);

        Console.Write("Destino:");
        Posicao destino = Tela.lerPosicaoXadrez().toPosicao();

        partida.executaMovimento(origem, destino);

    }
    Tela.imprimirTabuleiro(partida.tab);
    Console.ReadLine();
}
catch (TabuleiroException e)
{
    Console.WriteLine(e.Message);
}
