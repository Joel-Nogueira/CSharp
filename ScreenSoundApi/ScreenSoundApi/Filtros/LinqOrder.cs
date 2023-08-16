using ScreenSoundApi.Modelos;
using System.Linq;

namespace ScreenSoundApi.Filtros;

class LinqOrder
{
    public static void ExibirListaDeArtistasOrdenados(List<Musica> musicas)
    {
        var artistasOrdenados = musicas
            .OrderBy(musica => musica.Artista)
            .Select(musica => musica.Artista)
            .Distinct()
            .ToList();
        foreach (string artista in artistasOrdenados)
        {
            Console.WriteLine(artista);
        }
    }
}
