using Microsoft.AspNetCore.Mvc;
using FilmesApi.Models;
using FilmesApi.Data;
using FilmesApi.Data.Dtos;
using AutoMapper;

namespace FilmesApi.Controllers;

[ApiController]
[Route("[controller]")]
public class FilmeController : ControllerBase
{
    private FilmeContext _context;
    private IMapper _mapper;

    public FilmeController(FilmeContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    [HttpPost]
    public IActionResult AdicionarFilme([FromBody] CreateFilmeDto filmeDto)
    {
        Filme filme = _mapper.Map<Filme>(filmeDto);

        _context.Filmes.Add(filme);
        _context.SaveChanges();

        return CreatedAtAction(nameof(RecuperarFilmePorId),
            new { id = filme.Id},
            filme);
    }

    [HttpGet]
    public IEnumerable<Filme> RecuperarTodosOsFilmes([FromQuery] int skip = 0, [FromQuery] int take = 10)
    {
        return _context.Filmes.Skip(skip).Take(take);
    }

    [HttpGet("{id}")]
    public IActionResult RecuperarFilmePorId(int id)
    {
        Filme filme = _context.Filmes.FirstOrDefault(f => f.Id == id);

        if (filme == null) 
            return NotFound();

        return Ok(filme);
    }
}
