namespace BatalhaNaval;

public class sistemas
    {
       int[,] mapa = new int[10, 10];
        Random random = new Random();
        static int pontos = 0;
        static int tiros = 15;

        void pontuação(){
            InicioMap();

            Console.WriteLine("Batalha Naval");

            while(tiros > 0)
            {
            Console.Clear()

            Console.WriteLine($"tiros restantes: {tiros}");

            Console.Write("Informe a linha (0-9): ");
            int linha = int.Parse(Console.ReadLine());

            Console.Write("Informe a coluna (0-9): ");
            int coluna = int.Parse(Console.ReadLine());

            if (linha < 0 || linha > 9 || coluna < 0 || coluna > 9)
            {
                Console.WriteLine("Coordenadas inválidas. Tente novamente.");
                continue;
            }

            if (mapa[linha, coluna] == 1)
            {
                Console.WriteLine("Você atingiu um Porta-Avião!");
                destacar(mapa, linha, coluna, 'V');
                pontos + 5;
            }
            else if (mapa[linha, coluna] == 2)
            {
                Console.WriteLine("Você atingiu um Rebocador!");
                destacar(mapa, linha, coluna, 'V');
                pontos + 10;
            }
            else if (mapa[linha, coluna] == 3)
            {
                Console.WriteLine("Você atingiu um Cruzador!");
                destacar(mapa, linha, coluna, 'V');
                pontos + 15;
            }
            else
            {
                Console.WriteLine("Você errou o tiro.");
                 destacar(mapa, linha, coluna, 'M');
            }

            mapa[linha, coluna] = -1; 
            tiros--;
        }
        
        Console.Clear();
        RevelarMapa(mapa);
        Console.WriteLine($"Pontuação final: {pontos}");
        
    }
}
