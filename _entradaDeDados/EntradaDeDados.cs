using System;
public partial class EntradaDados:Board
{
    int jogada, pontos;
    
    void Pontuacao()
    {
        if(Board.pAviao)
        {
            pontos += 5;
            Console.ForegroundColor = ConsoleColor.Red;
        }
        else if(Board.Reboque)
        {
            pontos += 10;
            Console.ForegroundColor = ConsoleColor.Red;

        }
        else if(Board.Cruzador)
        {
            pontos += 15;
            Console.ForegroundColor = ConsoleColor.Red;
        }

        if(jogada = Empty)
        {
            jogada = Console.ForegroundColor = Console;
            if(jogada == Empty)
            {
                Console.WriteLine("");
            }
        }
    }
}