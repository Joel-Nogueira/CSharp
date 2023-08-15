class Episodio
{
    public Episodio(int duracao = 0, int numero = 0, string titulo = null)
    {
        Duracao = duracao;
        Numero = numero;
        Titulo = titulo;
    }
    public int Duracao { get; }
    public int Numero { get; }
    public string Resumo => $"{Numero}: {Titulo} - Duração: {Duracao}";
    public string Titulo { get; }

    List<string> _convidados = new List<string>();

    public void AdicionarConvidados(string convidado)
    {
        _convidados.Add(convidado);
    }
}