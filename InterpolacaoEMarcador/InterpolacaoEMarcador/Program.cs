// See https://aka.ms/new-console-template for more information
Console.WriteLine("Qual o seu nome?");
string nome = Console.ReadLine();

Console.WriteLine($"Essa é a sintaxe de interpolação, {nome}");
Console.WriteLine("Essa é a sintaxe dos marcadores, {0}", nome);