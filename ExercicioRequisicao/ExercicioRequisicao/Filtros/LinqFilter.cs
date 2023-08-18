using ExercicioRequisicao.Modelos;

namespace ExercicioRequisicao.Filtros;

class LinqFilter
{
    public static void ExibirApenasTodosOsGenerosMusicais(List<Modelos.Musica> musicas)
    {
        List<string> generos = musicas
            .Select(m => m.Genero)
            .Distinct()
            .ToList();

        foreach (string genero in generos)
        {
            Console.WriteLine($"- {genero}");
        }
    }

    public static void ExibirArtistasPorGeneroMusical(List<Musica> musicas, string genero)
    {
        List<string> artistasPorGenero = musicas
            .Where(m => m.Genero.Contains(genero))
            .Select(m => m.Artista)
            .Distinct()
            .ToList();

        foreach (string artista in artistasPorGenero)
        {
            Console.WriteLine($"- {artista}");
        }
    }

    public static void ExibirMusicasPorArtista(List<Musica> musicas, string artista)
    {
        List<Musica> musicasPorArtista = musicas.FindAll(m => m.Artista.Equals(artista));

        foreach (Musica musica in musicasPorArtista)
        {
            musica.ExibirInformacoes();
        }
    }
    
    public static void ExibirMusicasPorAno(List<Musica> musicas, string ano)
    {
        List<Musica> musicasPorAno = musicas.FindAll(m => m.Ano.Equals(ano));

        foreach (Musica musica in musicasPorAno)
        {
            musica.ExibirInformacoes();
        }
    }
}
