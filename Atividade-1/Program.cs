

Console.WriteLine(@"
██████████████████████████████████████████████████████████████████████████████████████
██▀▄─██─▄▄▄─█▄─▄▄─█▄─▄▄▀█─▄─▄─█▄─▄▄─███─▄▄─███▄─▀█▄─▄█▄─██─▄█▄─▀█▀─▄█▄─▄▄─█▄─▄▄▀█─▄▄─█
██─▀─██─███▀██─▄█▀██─▄─▄███─████─▄█▀███─██─████─█▄▀─███─██─███─█▄█─███─▄█▀██─▄─▄█─██─█
▀▄▄▀▄▄▀▄▄▄▄▄▀▄▄▄▄▄▀▄▄▀▄▄▀▀▄▄▄▀▀▄▄▄▄▄▀▀▀▄▄▄▄▀▀▀▄▄▄▀▀▄▄▀▀▄▄▄▄▀▀▄▄▄▀▄▄▄▀▄▄▄▄▄▀▄▄▀▄▄▀▄▄▄▄▀");
void MenuJogo()
{
    while (true)
    {
        Console.WriteLine("Digite 1 para jogar");
        Console.WriteLine("Digite -1 para sair...");

        string opcaoEscolhida = Console.ReadLine();
        int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

        if (!int.TryParse(opcaoEscolhida, out opcaoEscolhidaNumerica))
        {
            Console.WriteLine("Entrada inválida, digite um número.");
            continue;
        }
        switch (opcaoEscolhidaNumerica)
        {
            case 1:
                IniciarJogo();
                break;
            case -1:
                Console.WriteLine("Você escolheu Sair! Tchau, Tchau :)");
                return;
            default:
                Console.WriteLine("Opção inválida!");
                break;
        }
        break;
    }
}
MenuJogo();

static void IniciarJogo()
{
    Random rand = new Random();
    int numeroSecreto = rand.Next(1, 101);
    int tentativa;

    do
    {
        
        Console.WriteLine("\n****************");
        Console.Write("Faça seu palpite: ");
        string entrada = Console.ReadLine();

        if (!int.TryParse(entrada, out tentativa))
        {
            Console.WriteLine("Por favor, digite um número válido.");
            continue;
        }


        if (tentativa < 1 || tentativa > 100)
        {
            Console.WriteLine("\nO número deve estar entre 1 e 100.");
            Console.WriteLine($"Você digitou : {entrada}");

            continue;
        }

        if (tentativa < numeroSecreto)
        {
            Console.WriteLine("\nSeu palpite é MENOR que o número secreto.");
            Console.WriteLine($"Você digitou : {entrada}");

        }
        else if (tentativa > numeroSecreto)
        {
            Console.WriteLine("\nSeu palpite é MAIOR que o número secreto.");
            Console.WriteLine($"Você digitou : {entrada}");

        }
        else
        {
            MostrarEfeitoAcerto();
            break;

        }
    }
    while (true);
    Console.WriteLine("Fim de jogo, Obrigado Por jogar");
}

static void MostrarEfeitoAcerto()
{
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.Green;

    string[] fogos = new string[]
    {
            "    *     *     *",
            "  *   * *   * *   *",
            "*  💥  💥  💥  💥  💥 *",
            "  *   * *   * *   *",
            "    *     *     *"
    };

    foreach (var linha in fogos)
    {
        Console.WriteLine(linha);
        Thread.Sleep(300); // pausa para criar o efeito
    }

    Console.WriteLine("\n🎉 PARABÉNS! Você acertou o número secreto! 🎉");
    Console.ResetColor();
    Thread.Sleep(5500); // espera antes de voltar ao menu
    Console.Clear();
}

