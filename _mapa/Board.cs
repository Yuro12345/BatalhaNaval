using System.Text;

class Board
{
    public Board()
    {
        mapa();
        EmptyBoard();
    }
    public String[,] mapa()
    {
        String[,] Tabuleiro = new String[10, 10];
        int row, column;
        for (int agua = 0; agua < 87; agua++)
        {
            do
            {
                row = new Random().Next(10);
                column = new Random().Next(10);
            } while (Tabuleiro[row, column] != null);
            Tabuleiro[row, column] = "A";
        }
        for (int pAviao = 0; pAviao < 10; pAviao++)
        {
            do
            {
                row = new Random().Next(10);
                column = new Random().Next(10);
            } while (Tabuleiro[row, column] != null);
            Tabuleiro[row, column] = "P";
        }
        for (int Reboque = 0; Reboque < 2; Reboque++)
        {
            do
            {
                row = new Random().Next(10);
                column = new Random().Next(10);
            } while (Tabuleiro[row, column] != null);
            Tabuleiro[row, column] = "R";
        }
        for (int Cruzador = 0; Cruzador < 1; Cruzador++)
        {
            do
            {
                row = new Random().Next(10);
                column = new Random().Next(10);
            } while (Tabuleiro[row, column] != null);
            Tabuleiro[row, column] = "C";
        }

        // Código a ser usado no final do jogo(mostrar a tabela completa junto ao resultado da partida)

        // for (int linha = 0; linha < Tabuleiro.GetLength(0); linha++)
        // {
        //     for (int coluna = 0; coluna < Tabuleiro.GetLength(1); coluna++)
        //     {
        //         Console.Write("{0}|", Tabuleiro[linha, coluna]);
        //     }
        //     Console.WriteLine();
        // }
        return Tabuleiro;
    }
    public String[,] EmptyBoard()
    {
        String[,] TabuleiroVazio = new String[10, 10];
        PercorreTabuleiro(TabuleiroVazio);
        return TabuleiroVazio;
    }
    public void PercorreTabuleiro(String[,] TabuleiroVazio)
    {
        for (int linha = 0; linha < TabuleiroVazio.GetLength(0); linha++)
        {
            Console.WriteLine("---------------------------------------|");
            for (int coluna = 0; coluna < TabuleiroVazio.GetLength(1); coluna++)
            {
                Console.Write($"   |", TabuleiroVazio[linha, coluna]);
            }
            Console.WriteLine(linha);
        }
        Console.WriteLine("---------------------------------------|");
        Console.WriteLine(" 0   1   2   3   4   5   6   7   8   9");
    }
    public String CompareBoard(int linha, int coluna, String[,] Tabuleiro, String[,] TabuleiroVazio)
    {
        String jogada = Tabuleiro[linha, coluna];
        if (TabuleiroVazio[linha, coluna] == null)
        {
            TabuleiroVazio[linha, coluna] = jogada;
        }
        else
        {
            Console.WriteLine("Posição inválida");
        }
        return jogada;
    }
    public void Jogada(String jogada, String[,] TabuleiroVazio)
    {
        switch (jogada)
        {
            case "P":
                PercorreTabuleiro(TabuleiroVazio);
                break;
            case "R":
                PercorreTabuleiro(TabuleiroVazio);
                break;
            case "C":
                PercorreTabuleiro(TabuleiroVazio);
                break;
            case "A":
                PercorreTabuleiro(TabuleiroVazio);
                break;
        }

    }
}