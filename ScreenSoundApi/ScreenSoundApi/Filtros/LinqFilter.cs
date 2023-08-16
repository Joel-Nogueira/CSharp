using ScreenSoundApi.Modelos;
using System.Linq;

namespace ScreenSoundApi.Filtros;

class LinqFilter
{
    public static void FiltrarTodosOsGenerosMusicais(List<Musica> musicas)
    {
        var todosOsGenerosMusicais = musicas.Select(m => m.Genero).Distinct().ToList();
        /*Console.WriteLine(string.Join(", ", todosOsGenerosMusicais));*/
        foreach(string genero in todosOsGenerosMusicais)
        {
            Console.WriteLine(genero);
        }
    }

    public static void FiltrarArtistasPorGeneroMusical(List<Musica> musicas, string genero)
    {
        var artistasPorGeneroMusical = musicas
            .Where(musica => musica.Genero.Contains(genero))
            .Select(musica => musica.Artista)
            .Distinct()
            .ToList();

        foreach (string artista in artistasPorGeneroMusical)
        {
            Console.WriteLine(artista);
        }
    }

    public static void FiltrarMusicasDeUmArtista(List<Musica> musicas, string artista)
    {
        var musicasDoArtista = musicas
            .Where(musica => musica.Artista.Equals(artista))
            .Select(musica => musica.Nome)
            .Distinct()
            .ToList();

        foreach (string musica in musicasDoArtista)
        {
            Console.WriteLine(musica);
        }
    }
}
