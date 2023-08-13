class Musica
{
    public string nome;
    public string artista;
    public int duracao;
    public bool disponivel;

    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome: {nome}");
        Console.WriteLine($"Artista: {artista}");
        Console.WriteLine($"Duração: {duracao}");

        string mensagem = "Adquira o plano Plus";
        if (disponivel)
            mensagem = "Disponível no plano";

        Console.WriteLine($"Disponível: {mensagem}");
    }
}