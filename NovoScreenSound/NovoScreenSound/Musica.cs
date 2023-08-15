class Musica
{
    public Musica(Banda artista, string nome)
    {
        Artista = artista;
        Nome = nome;
    }

    public string Nome { get; }
    public Banda Artista { get; }
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
        Console.WriteLine($"Artista: {Artista.Nome}");
        Console.WriteLine($"Duração: {Duracao}");

        string mensagem = "Adquira o plano Plus";
        if (Disponivel)
            mensagem = "Disponível no plano";

        Console.WriteLine($"Disponível: {mensagem}\n");
    }
}