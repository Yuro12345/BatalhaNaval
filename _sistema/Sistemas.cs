// namespace BatalhaNaval;
// public class Sistemas
// {
//     static int pontos = 0;
//     static int tiros = 15;

//     void pontuação()
//     {
//         //comentarios feito pelo Luiz(aqui acho q seria o EmptyBoard sepa)
//         Board.EmptyBoard();
//         Console.WriteLine();
//         Console.WriteLine("BATALHA NAVAL");

//         while (tiros > 0)
//         {
//             Console.Clear();

//             Console.WriteLine($"tiros restantes: {tiros}");

//             Console.Write("Informe a linha (0-9): ");
//             int linha = int.TryParse(Console.ReadLine(), out int auxlinha) ? auxlinha : default;

//             Console.Write("Informe a coluna (0-9): ");
//             int coluna = int.TryParse(Console.ReadLine(), out int auxcoluna) ? auxcoluna : default;

//             if (linha < 0 || linha > 9 || coluna < 0 || coluna > 9)
//             {
//                 Console.WriteLine("Coordenadas inválidas. Tente novamente.");
//                 continue;
//             }
//             //aqui acho que seria o Board mesmo p verificar as cordenada se tem algo
//             if (Board.mapa(tabuleiro[linha, coluna] == "P"))
//             {
//                 Console.WriteLine("Você atingiu um Porta-Avião!");
//                 //chamar o metodo que coloque no EmptyBoard a posição exata do porta aviao p printar ele, falta ele mudar de cor tb
//                 destacar(mapa, linha, coluna, 'V');
//                 pontos += 5;
//             }
//             else if (mapa[linha, coluna] == 2)
//             {
//                 Console.WriteLine("Você atingiu um Rebocador!");
//                 //chamar o metodo que coloque no EmptyBoard a posição exata do porta aviao p printar ele, falta ele mudar de cor tb
//                 destacar(mapa, linha, coluna, 'V');
//                 pontos = +10;
//             }
//             else if (mapa[linha, coluna] == 3)
//             {
//                 Console.WriteLine("Você atingiu um Cruzador!");
//                 //chamar o metodo que coloque no EmptyBoard a posição exata do porta aviao p printar ele, falta ele mudar de cor tb
//                 destacar(mapa, linha, coluna, 'V');
//                 pontos += 15;
//             }
//             else
//             {
//                 Console.WriteLine("Você errou o tiro.");
//                 //chamar o metodo que coloque no EmptyBoard a posição exata do porta aviao p printar ele, falta ele mudar de cor tb
//                 //aqui falta a questao de falar se em 1,2 ou 3 casas tem algo perto (cima, baixo, lado)
//                 destacar(mapa, linha, coluna, 'M');
//             }

//             mapa[linha, coluna] = -1;
//             tiros--;
//         }

//         Console.Clear();
//         //só printar o Board original (pintar ja quando gera o tabuleiro, acho que facilita)
//         //acho que isso podia ser outra classe tambem, exclusiva p printar o mapa e resultado
//         Board.mapa();
//         Console.WriteLine($"Pontuação final: {pontos}");

//     }
// }
