class Play
{
    public Board board;
    public Play(Board board)
    {
        this.board = board;
    }
    public void Jogabilidade(int linha, int coluna)
    {
        for (int tiros = 15; tiros >= 0; tiros--)
        {
            String[,] Tabuleiro = board.mapa();
            String[,] TabuleiroVazio = board.EmptyBoard();
            Console.WriteLine($"Você tem {tiros} tiros restantes, escolha a linha entre 0 e 9:");
            linha = int.TryParse(Console.ReadLine(), out int auxlinha) ? auxlinha : linha = new Random().Next(9);
            Console.WriteLine($"Escolha a coluna entre 0 e 9:");
            coluna = int.TryParse(Console.ReadLine(), out int auxcoluna) ? auxcoluna : coluna = new Random().Next(9);
            board.CompareBoard(linha, coluna, Tabuleiro, TabuleiroVazio);

        }
    }

}