var notasAlunos = new Dictionary<string, Dictionary<string, List<int>>> {
    { "Ana", new Dictionary<string, List<int>> {
        { "C#", new List<int> { 8, 7, 6 } },
        { "Java", new List<int> { 7, 6, 5 } },
        { "Python", new List<int> { 9, 8, 8 } }
    }},
    { "Maria", new Dictionary<string, List<int>> {
        { "C#", new List<int> { 6, 5, 4 } },
        { "Java", new List<int> { 8, 7, 6 } },
        { "Python", new List<int> { 6, 10, 5 } }
    }},
    { "Luiza", new Dictionary<string, List<int>> {
        { "C#", new List<int> { 2, 3, 10 } },
        { "Java", new List<int> { 8, 8, 8 } },
        { "Python", new List<int> { 7, 7, 7 } }
    }}
};

double  CalculaMedia(List<int> notas)
{
    int quantidadeDeNotas = notas.Count;
    int somatorioDasNotas = 0;

    foreach (int nota in notas)
    {
        somatorioDasNotas += nota;
    }

    return (somatorioDasNotas / quantidadeDeNotas);
}

List<int> notasAnaCSharp = notasAlunos["Ana"]["C#"];
/*double media = CalculaMedia(notasAnaCSharp);*/
double media = notasAnaCSharp.Average();

Console.WriteLine($"A média da Ana em C# é {media}");

List<int> notasMariaPython = notasAlunos["Ana"]["C#"];
/*media = CalculaMedia(notasMariaPython);*/
media = notasMariaPython.Average();
Console.WriteLine($"A média da Maria em Python é {media}");