using Microsoft.AspNetCore.Mvc;
using FilmesApi.Models;

namespace FilmesApi.Controllers;

[ApiController]
[Route("[controller]")]
public class FilmeController : ControllerBase
{
    private static List<Filme> filmes = new List<Filme>();
    private static int _id = 0;

    [HttpPost]
    public IActionResult AdicionarFilme([FromBody] Filme filme)
    {
        filme.Id = _id++;
        filmes.Add(filme);
        return CreatedAtAction(nameof(RecuperarFilmePorId),
            new { id = filme.Id},
            filme);
    }

    [HttpGet]
    public IEnumerable<Filme> RecuperarTodosOsFilmes([FromQuery] int skip = 0, [FromQuery] int take = 10)
    {
        return filmes.Skip(skip).Take(take);
    }

    [HttpGet("{id}")]
    public IActionResult RecuperarFilmePorId(int id)
    {
        Filme filme = filmes.FirstOrDefault(f => f.Id == id);

        if (filme == null) 
            return NotFound();

        return Ok(filme);
    }
}
