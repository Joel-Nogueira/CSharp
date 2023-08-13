class Musica
{
    public string Nome { get; set; }
    public string Artista {get; set; }
    public int Duracao {get; set; }
    public bool Disponivel { get; set; }

    public string Descricao =>
        $"A música {Nome} pertence à banda {Artista}";

    /*public string Descricao 
    {
        get
        {
            return $"A música {Nome} pertence à banda {Artista}";
        }
    }*/

    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Artista: {Artista}");
        Console.WriteLine($"Duração: {Duracao}");

        string mensagem = "Adquira o plano Plus";
        if (Disponivel)
            mensagem = "Disponível no plano";

        Console.WriteLine($"Disponível: {mensagem}");
    }
}