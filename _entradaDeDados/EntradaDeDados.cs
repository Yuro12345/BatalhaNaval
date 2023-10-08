using BatalhaNaval;

internal partial class Program:sistemas
{
    int[,] mapa = new int[10, 10];
    int row, column;

    public void InsercaoDados()
    {
        for (int jogadas = 1; jogadas <= 15; i++)
        {
            Console.WriteLine($"Jogadas: {jogadas}    Pontuação: {pontuação.pontos}");

            for (int i = 1; i <= 15; i++)
            {
                Concole.Clear();

                Console.WriteLine("Digite a posição que você deseja jogar:");
                mapa[row, column] = Console.ReadLine();

                Console.WriteLine(mapa);
            }
        }
    }
}