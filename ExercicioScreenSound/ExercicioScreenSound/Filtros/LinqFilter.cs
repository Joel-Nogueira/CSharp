using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

using ExercicioScreenSound.Modelos;

namespace ExercicioScreenSound.Filtros;

class LinqFilter
{
    public static void FiltrarPorAno (List<Musica> musicas, string ano)
    {
        List<string> musicasPorAno = musicas
            .Where(m => m.Ano.Equals(ano))
            .Select(m => m.Nome)
            .Distinct()
            .ToList();

        foreach (string musica in musicasPorAno)
        {
            Console.WriteLine($"- {musica}");
        }
    }

    public static void OrdenarPorAno(List<Musica> musicas)
    {
        List<string> musicasPorAno = musicas
            .OrderBy(m => m.Ano)
            .Select(m => m.Nome)
            .Distinct()
            .ToList();

        foreach (string musica in musicasPorAno)
        {
            Console.WriteLine($"- {musica}");
        }
    }

    public static void GerarJson(List<Musica> musicas)
    {
        List<Musica> _musicas = new List<Musica>();
        _musicas.Add(musicas[88]);
        _musicas.Add(musicas[99]);
        _musicas.Add(musicas[111]);
        _musicas.Add(musicas[222]);
        _musicas.Add(musicas[333]);

        string json = JsonSerializer.Serialize(new
        {
            nome = "Teste antes de dormir",
            musicas = _musicas,
        });

        File.WriteAllText("NomeDeArquivo.json", json);
        Console.WriteLine(Path.GetFullPath("NomeDeArquivo.json"));
    }
}
