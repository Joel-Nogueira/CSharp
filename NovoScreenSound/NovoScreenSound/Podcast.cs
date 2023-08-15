class Podcast
{
    public Podcast(string host, string nome)
    {
        Host = host;
        Nome = nome;
        _totalEpisodios = 0;
    }

    private List<Episodio> _episodios = new List<Episodio>();

    public string Host { get; }
    public string Nome { get; }

    public int _totalEpisodios;

    public void AdicionarEpisodio(Episodio episodio)
    {
        _episodios.Add(episodio);
        _totalEpisodios++;
    }

    public void ExibirDetalhes()
    {
        Console.WriteLine($"Host: {Host}, Nome: {Nome}");
        Console.WriteLine("Lista de episódios");
        _episodios.Sort((e1, e2) => e1.Numero.CompareTo(e2.Numero));
        foreach (Episodio episodio in _episodios)
        {
            Console.WriteLine($"{episodio.Resumo}");
        }
        Console.WriteLine($"Total de episódios: {_totalEpisodios}");
    }
}