// Screen Sound
string mensagemDeBoasVindas = "Boas vindas ao Screen Sound.";
//List<string> bandas = new List<string> { "U2", "The Beatles", "Calipso"};

Dictionary< string, List<int>> bandas = new Dictionary< string, List<int>>();
bandas.Add("Link Park", new List<int> { 10, 8, 6});
bandas.Add("The Beatles", new List<int>());

void ExibirLogo()
{
    Console.WriteLine(@"
        ░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
        ██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
        ╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
        ░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
        ██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
        ╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
    ");
    Console.WriteLine(mensagemDeBoasVindas);
}

void ExibirOpcoesDoMenu()
{
    Console.WriteLine("\nDigite 1 para registrar uma bada");
    Console.WriteLine("Digite 2 para mostrar todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir a média de uma bada");
    Console.WriteLine("Digite -1 para sair");

    Console.Write("\nDigir a sua opção: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

    switch (opcaoEscolhidaNumerica)
    {
        case 1:
            RegistrarBandas();
            break;
        case 2:
            ExibirBandasRegistradas();
            break;
        case 3:
            AvaliarBanda();
            break;
        case 4:
            ExibirMediaDaBanda();
            break;
        case -1:
            Console.WriteLine("Você saiu do Screen Sound.");
            break;
        default:
            Console.WriteLine("Opção inválida.");
            break;
    }
}

void ExibirMenu()
{
    ExibirLogo();
    ExibirOpcoesDoMenu();
}

void ExibirTituloDaOpcao(string titulo)
{
    int quantidadeDeLetras = titulo.Length;
    string asteriscos = string.Empty.PadLeft(quantidadeDeLetras, '*');

    Console.WriteLine(asteriscos);
    Console.WriteLine(titulo);
    Console.WriteLine(asteriscos);
}

void RegistrarBandas()
{
    Console.Clear();
    ExibirTituloDaOpcao("Registro de bandas");
    Console.WriteLine();

    Console.Write("Digite o nome da banda que deseja registrar: ");
    string nomeDaBanda = Console.ReadLine()!;
    bandas.Add(nomeDaBanda, new List<int>());
    Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso!");
    Thread.Sleep(2000);
    Console.Clear();
    ExibirMenu();
}

void ExibirBandasRegistradas()
{
    Console.Clear();
    ExibirTituloDaOpcao("Bandas registradas");
    Console.WriteLine();

    if (bandas.Count > 0)
    {
        foreach (string banda in bandas.Keys)
        {
            Console.WriteLine($"Banda: {banda}");
        }
    }

    Console.WriteLine("\nDigite alguma tecla para voltar ao menu principal");
    Console.ReadKey();
    Console.Clear();
    ExibirMenu();
}

void AvaliarBanda()
{
    Console.Clear();
    ExibirTituloDaOpcao("Avaliar banda");
    Console.WriteLine();
    
    Console.Write("Digite o nome da banda que deseja avaliar: ");
    string nomeDaBanda = Console.ReadLine()!;

    if (bandas.ContainsKey(nomeDaBanda))
    {
        Console.Write($"Qual a nota da banda {nomeDaBanda} merece: ");
        int nota = int.Parse(Console.ReadLine()!);
        bandas[nomeDaBanda].Add(nota);
        Console.WriteLine($"A nota {nota} foi registrada com sucesso para a banda {nomeDaBanda}");
        Thread.Sleep(4000);
        Console.Clear();
    }
    else
    {
        Console.WriteLine($"A banda {nomeDaBanda} não foi encontrada.");
        Console.WriteLine("\nDigite alguma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
    }

    ExibirMenu();
}

void ExibirMediaDaBanda()
{
    Console.Clear();
    ExibirTituloDaOpcao("Média da banda");
    Console.Write("De qual banda você quer ver a média? ");
    string banda = Console.ReadLine()!;
    if (bandas.ContainsKey(banda))
    {
        double media = 0;
        if (bandas[banda].Count > 0)
            media = bandas[banda].Average();

        Console.WriteLine($"A média da banda {banda} é {media}.");
    }
    else
    {
        Console.WriteLine($"Não é possível saber média dessa {banda}, pois ela não foi cadastrada.");
    }
    Console.WriteLine("\nDigite qualquer tecla para voltar ao menu.");
    Console.ReadKey();
    ExibirOpcoesDoMenu();
}

ExibirMenu();