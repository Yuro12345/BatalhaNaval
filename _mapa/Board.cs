class Board
{
public Board(){
    mapa();
}
    void mapa()
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
        for (int linha = 0; linha < Tabuleiro.GetLength(0); linha++)
        {
            for (int coluna = 0; coluna < Tabuleiro.GetLength(1); coluna++)
            {
                Console.Write("{0}|", Tabuleiro[linha, coluna]);
            }
            Console.WriteLine();
        }
    }
}