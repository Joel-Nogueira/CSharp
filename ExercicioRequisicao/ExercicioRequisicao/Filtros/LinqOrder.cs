using System.Linq;

namespace ExercicioRequisicao.Filtros;

class LinqOrder
{
    public static void OrdenarArtistasPorNome(List<Modelos.Musica> musicas)
    {
        List<string> artistasOrdenados = musicas
            .OrderBy(m => m.Artista)
            .Select(m => m.Artista)
            .Distinct()
            .ToList();

        foreach (string artista in artistasOrdenados)
        {
            Console.WriteLine($"- {artista}");
        }
    }
}
