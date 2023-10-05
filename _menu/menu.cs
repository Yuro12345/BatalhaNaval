public class Menu
{
    public void menu()
    {
        Console.Write("1-Jogar||0-Sair:");
        byte escolha = (byte.TryParse(Console.ReadLine(), out byte auxescolha)) ? auxescolha : default;
        while (escolha != 0)
        {
            switch (escolha)
            {
                case 1:
                    new Board();
                    break;
                default:
                    break;
            }
            Console.Write("1-Jogar||0-Sair:");
            escolha = (byte.TryParse(Console.ReadLine(), out auxescolha)) ? auxescolha : default;
        }
    }

}