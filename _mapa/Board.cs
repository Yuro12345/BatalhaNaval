

public class Board
{
    public char jogada { get; set; }
    public int pontos { get; set; }
    public String[,] TabuleiroPopulado { get; set; }
    public String[,] jogadasAnteriores = new String[10, 10];
    public int[] coordenadas_linha = new int[10];
    public int[] coordenadas_coluna = new int[10];

    public Board()
    {

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
        this.TabuleiroPopulado = Tabuleiro;
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
        // for (int i = 0; i < 10; i++)
        // {
        //     coordenadas_linha[linha] = linha;
        //     coordenadas_coluna[coluna] = coluna;
        // }

        // this.TabuleiroPopulado[linha, coluna] = this.jogada.ToString();

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
    public char CompareBoard(int linha, int coluna, String[,] Tabuleiro, String[,] TabuleiroVazio)
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
        return char.Parse(jogada);
    }
    public void Jogada(char jogada)
    {
        Console.ResetColor();
        switch (jogada)
        {
            case 'P':
                Pontuacao(jogada);
                // PercorreTabuleiro(TabuleiroPopulado);
                this.jogada = jogada;
                break;
            case 'R':
                Pontuacao(jogada);

                // PercorreTabuleiro(TabuleiroPopulado);
                this.jogada = jogada;
                break;
            case 'C':
                Pontuacao(jogada);

                // PercorreTabuleiro(TabuleiroPopulado);
                this.jogada = jogada;

                break;
            case 'A':
                // PercorreTabuleiro(TabuleiroPopulado);
                this.jogada = jogada;
                break;
        }
    }
    public void proximidade(int linha, int coluna)
    {
        try
        {
            if (TabuleiroPopulado[linha, coluna - 1] == "A")
            {
                TabuleiroPopulado[linha, coluna - 1] = "1";
            }
        }
        catch
        {
            
        }

        try
        {
            if (TabuleiroPopulado[linha, coluna - 2] == "A")
            {
                TabuleiroPopulado[linha, coluna - 2] = "2";
            }
        }
        catch
        {
            
        }

        try
        {
            if (TabuleiroPopulado[linha, coluna - 3] == "A")
            {
                TabuleiroPopulado[linha, coluna - 3] = "3";
            }
        }
        catch
        {
            
        }

        try
        {
            if (TabuleiroPopulado[linha, coluna + 1] == "A")
            {
                TabuleiroPopulado[linha, coluna + 1] = "1";
            }
        }
        catch
        {
            
        }

        try
        {
            if (TabuleiroPopulado[linha, coluna + 2] == "A")
            {
                TabuleiroPopulado[linha, coluna + 2] = "2";
            }
        }
        catch
        {
            
        }

        try
        {
            if (TabuleiroPopulado[linha, coluna + 3] == "A")
            {
                TabuleiroPopulado[linha, coluna + 3] = "3";
            }
        }
        catch
        {
            
        }

        try
        {
            if (TabuleiroPopulado[linha - 1, coluna] == "A")
            {
                TabuleiroPopulado[linha - 1, coluna] = "1";
            }
        }
        catch
        {
            
        }

        try
        {
            if (TabuleiroPopulado[linha - 2, coluna] == "A")
            {
                TabuleiroPopulado[linha - 2, coluna] = "2";
            }
        }
        catch
        {
            
        }

        try
        {
            if (TabuleiroPopulado[linha - 3, coluna] == "A")
            {
                TabuleiroPopulado[linha - 3, coluna] = "3";
            }
        }
        catch
        {
            
        }

        try
        {
            if (TabuleiroPopulado[linha + 1, coluna] == "A")
            {
                TabuleiroPopulado[linha + 1, coluna] = "1";
            }
        }
        catch
        {
            
        }

        try
        {
            if (TabuleiroPopulado[linha + 2, coluna] == "A")
            {
                TabuleiroPopulado[linha + 2, coluna] = "2";
            }
        }
        catch
        {
            
        }

        try
        {
            if (TabuleiroPopulado[linha + 3, coluna] == "A")
            {
                TabuleiroPopulado[linha + 3, coluna] = "3";
            }
        }
        catch
        {
            
        }

    }

    public void Popular(int linha, int coluna)
    {
        coordenadas_linha[linha] = linha;
        coordenadas_coluna[coluna] = coluna;
        this.TabuleiroPopulado[linha, coluna] = this.jogada.ToString();
        proximidade(linha, coluna);

        for (int i = 0; i < TabuleiroPopulado.GetLength(0); i++)
        {
            Console.WriteLine("---------------------------------------|");
            for (int j = 0; j < TabuleiroPopulado.GetLength(1); j++)
            {
                if (i == coordenadas_linha[linha] && j == coordenadas_coluna[coluna])
                {
                    Console.Write($" {TabuleiroPopulado[linha, coluna]} |");
                }
                else
                {
                    Console.Write($"   |");
                }
            }
            Console.WriteLine(i);
        }
        Console.WriteLine("---------------------------------------|");
        Console.WriteLine(" 0   1   2   3   4   5   6   7   8   9");
    }

    public void Pontuacao(char jogada)
    {
        if (jogada == 'P')
        {
            pontos += 5;
            Console.ForegroundColor = ConsoleColor.Red;
        }
        else if (jogada == 'R')
        {
            pontos += 10;
            Console.ForegroundColor = ConsoleColor.Red;

        }
        else if (jogada == 'C')
        {
            pontos += 15;
            Console.ForegroundColor = ConsoleColor.Red;
        }
    }
    public void Final(int linha, int coluna)
    {
        coordenadas_linha[linha] = linha;
        coordenadas_coluna[coluna] = coluna;
        this.TabuleiroPopulado[linha, coluna] = this.jogada.ToString();
        proximidade(linha, coluna);

        for (int i = 0; i < TabuleiroPopulado.GetLength(0); i++)
        {
            Console.WriteLine("---------------------------------------|");
            for (int j = 0; j < TabuleiroPopulado.GetLength(1); j++)
            {
                string valorAtual = TabuleiroPopulado[i, j];
                if (!string.IsNullOrEmpty(valorAtual))
                {
                    Console.Write($" {valorAtual} |");
                }
                else
                {
                    Console.Write($"   |");
                }
            }
            Console.WriteLine(i);
        }
        Console.WriteLine("---------------------------------------|");
        Console.WriteLine(" 0   1   2   3   4   5   6   7   8   9");
        Console.WriteLine($"Pontuação final:{pontos}");
    }
}


