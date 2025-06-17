// Screen sound
string mensagem = "Seja bem-vindo!";

void ExibirMensagem()
{
    Console.WriteLine(@"
░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░");
    Console.WriteLine(mensagem);
}

void ExibirMenu()
{
    Console.WriteLine("\nEscolha uma opção:");
    Console.WriteLine("\n1 - Cadastrar Banda");
    Console.WriteLine("2 - Listar todas as Bandas");
    Console.WriteLine("3 - Avaliar Banda");
    Console.WriteLine("4 - Exibir avaliação média da Banda ");
    Console.WriteLine("5 - Sair");
    Console.Write("\nDigite a opção desejada: ");
    string option = Console.ReadLine()!;

    switch (option)
    {
        case "1":
            Console.WriteLine("Opção 1 selecionada: Cadastrar Banda");
            // Chamar função para cadastrar banda
            break;
        case "2":
            Console.WriteLine("Opção 2 selecionada: Listar todas as Bandas");
            // Chamar função para listar bandas
            break;
        case "3":
            Console.WriteLine("Opção 3 selecionada: Avaliar Banda");
            // Chamar função para avaliar banda
            break;
        case "4":
            Console.WriteLine("Opção 4 selecionada: Exibir avaliação média da Banda");
            // Chamar função para exibir avaliação média
            break;
        case "5":
            Console.WriteLine("Saindo do programa...");
            Environment.Exit(0);
            break;
        default:
            Console.WriteLine("Opção inválida. Tente novamente.");
            ExibirMenu();
            break;
    }
}
ExibirMensagem();
ExibirMenu();   