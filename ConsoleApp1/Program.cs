string mensagemDeBoasVindas = "Bem Vindo ao Screen Sound!";
List<string> listaDeBandas = new List<string>();

void MostrarMensagemDeBoasVindas()
{
    Console.WriteLine(@"
░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░");
    Console.WriteLine(mensagemDeBoasVindas);
}

void MostrarMenuDoPrograma()
{
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para mostrar todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir média de uma banda");
    Console.WriteLine("Digite -1 para sair...");
    Console.Write("\nDigite a sua opção: ");
}

void RegistrarBanda()
{
    Console.Clear();
    Console.WriteLine("Registro de bandas");
    Console.Write("Digite o nome da banda: ");
    string nomeDaBanda = Console.ReadLine();
    listaDeBandas.Add(nomeDaBanda);
    Console.WriteLine($"\nA banda {nomeDaBanda} foi inserida no sistema.");
    Console.Write("Retornando ao menu...");
    Thread.Sleep(2000);
    Console.Clear();
}

void MostrarListaDeBandas()
{
    Console.Clear();
    Console.WriteLine("Lista de bandas cadastradas:");

    if (listaDeBandas.Count == 0)
    {
        Console.WriteLine("Nenhuma banda foi cadastrada ainda.");
    }
    else
    {
        foreach (var banda in listaDeBandas.OrderBy(b => b))
        {
            Console.WriteLine($"- {banda}");
        }
    }

    Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
    Console.ReadKey();
    Console.Clear();
}

// Execução
MostrarMensagemDeBoasVindas();

int opcaoNumerica;
do
{
    MostrarMenuDoPrograma();
    string opcaoDigitada = Console.ReadLine();

    if (!int.TryParse(opcaoDigitada, out opcaoNumerica))
    {
        Console.WriteLine("Opção inválida. Digite um número.");
        continue;
    }

    switch (opcaoNumerica)
    {
        case 1:
            RegistrarBanda();
            break;
        case 2:
            MostrarListaDeBandas();
            break;
        case 3:
            Console.WriteLine("Funcionalidade de avaliação ainda não implementada.");
            break;
        case 4:
            Console.WriteLine("Funcionalidade de média ainda não implementada.");
            break;
        case -1:
            Console.WriteLine("Tchau, tchau :)");
            break;
        default:
            Console.WriteLine("Opção inválida");
            break;
    }
} while (opcaoNumerica != -1);

