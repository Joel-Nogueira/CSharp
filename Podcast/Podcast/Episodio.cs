class Episodio
{
    List<string> _convidados = new();

    public Episodio(int duracao = 0, int numero = 0, string titulo = null)
    {
        Duracao = duracao;
        Numero = numero;
        Titulo = titulo;
    }
    public int Duracao { get; }
    public int Numero { get; }
    public string Resumo => $"{Numero}: {Titulo} - Duração: {Duracao} min {string.Join(", ", _convidados)}";
    public string Titulo { get; }

    public void AdicionarConvidados(string convidado)
    {
        _convidados.Add(convidado);
    }
}