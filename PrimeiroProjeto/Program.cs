// SCREEN SOUND

string mensagemBoasVindas = "Boas Vindas ao Screen Sound!";
List<string> listaDeBandas = new List<string>();

void ExibirBoasVindas ()
{
    Console.WriteLine(@"
░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
    ");
    Console.WriteLine(mensagemBoasVindas);
};

void ExibirMenuDeOpcoes ()
{
    ExibirBoasVindas();
    Console.WriteLine("\nESCOLHA A OPÇÃO DESEJADA: ");
    Console.WriteLine("1 - Registrar uma Banda");
    Console.WriteLine("2 - Mostrar todas as Bandas");
    Console.WriteLine("3 - Avaliar uma Banda");
    Console.WriteLine("4 - Exibir a média de uma Banda");
    Console.WriteLine("0 - Sair");

    Console.Write("\nDigite a sua opção: ");
    int opcaoEscolhida = int.Parse(Console.ReadLine()!);

    switch (opcaoEscolhida)
    {
        case 1:
            RegistrarUmaBanda();
            break;
        case 2: 
            Console.WriteLine(listaDeBandas);
            break;
        case 3:
            Console.WriteLine("Você escolheu a opção " + opcaoEscolhida);
            break;
        case 4:
            Console.WriteLine("Você escolheu a opção " + opcaoEscolhida);
            break;
        case 0:
            Console.WriteLine("Bye Bye :)");
            break;
        default:
            Console.WriteLine("Opção Inválida meu parceiro");
            break;
    }
}

void RegistrarUmaBanda ()
{
    Console.Clear();
    Console.WriteLine("*****************");
    Console.WriteLine("REGISTRO DE BANDA");
    Console.WriteLine("*****************");
    Console.Write("Digite o nome da banda: ");
    string nomeDaBanda = Console.ReadLine()!;
    listaDeBandas.Add(nomeDaBanda);
    Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso!");
    Thread.Sleep(2000);
    Console.Clear();
    ExibirMenuDeOpcoes();
}

ExibirMenuDeOpcoes();
