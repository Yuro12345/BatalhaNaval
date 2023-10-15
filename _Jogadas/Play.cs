class Play
{
    public Board board = new Board();
    public Play()
    {
        String[,] Tabuleiro = board.mapa();
        String[,] TabuleiroVazio = board.EmptyBoard();
        Jogabilidade(Tabuleiro, TabuleiroVazio);
    }
    public void Jogabilidade(String[,] Tabuleiro, String[,] TabuleiroVazio)
    {
        int linha = 0, coluna = 0;
        for (int tiros = 15; tiros >= 0; tiros--)
        {
            Console.WriteLine($"Você tem {tiros} tiros restantes, escolha a linha entre 0 e 9:");
            linha = int.TryParse(Console.ReadLine(), out int auxlinha) ? auxlinha : new Random().Next(9);
            Console.WriteLine($"Escolha a coluna entre 0 e 9:");
            coluna = int.TryParse(Console.ReadLine(), out int auxcoluna) ? auxcoluna : new Random().Next(9);
            char jogada = board.CompareBoard(linha, coluna, Tabuleiro, TabuleiroVazio);
            board.Jogada(jogada);
            board.Popular(linha, coluna);
            System.Console.WriteLine($"Voce tem {board.pontos} pontos!");
        }

        board.Final(linha, coluna);
    }

}