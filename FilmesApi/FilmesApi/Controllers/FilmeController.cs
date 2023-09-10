using Microsoft.AspNetCore.Mvc;
using FilmesApi.Models;
using FilmesApi.Data;
using FilmesApi.Data.Dtos;
using AutoMapper;
using Microsoft.AspNetCore.JsonPatch;
using System.Collections.Generic;

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
    public IEnumerable<ReadFilmeDto> RecuperarTodosOsFilmes([FromQuery] int skip = 0, [FromQuery] int take = 10)
    {
        IEnumerable<Filme> filmes = _context.Filmes.Skip(skip).Take(take);
        List<ReadFilmeDto> filmesDto = _mapper.Map<List<ReadFilmeDto>>(filmes);

        return filmesDto;
    }

    [HttpGet("{id}")]
    public IActionResult RecuperarFilmePorId(int id)
    {
        Filme filme = _context.Filmes.FirstOrDefault(f => f.Id == id);

        if (filme == null) 
            return NotFound();

        ReadFilmeDto filmeDto = _mapper.Map<ReadFilmeDto>(filme);

        return Ok(filmeDto);
    }

    [HttpPut("{id}")]
    public IActionResult AtualizarFilme(int id, [FromBody] UpdateFilmeDto filmeDto)
    {
        Filme filme = _context.Filmes.FirstOrDefault(f => f.Id == id);
        
        if (filme == null) return NotFound();

        _mapper.Map(filmeDto, filme);

        _context.SaveChanges();

        return NoContent();
    }

    [HttpPatch("{id}")]
    public IActionResult AtualizarFilmeParcialmente(int id, 
        JsonPatchDocument<UpdateFilmeDto> patch)
    {
        Filme filme = _context.Filmes.FirstOrDefault(f => f.Id == id);

        if (filme == null) return NotFound();

        UpdateFilmeDto filmeParaAtualizar = _mapper.Map<UpdateFilmeDto>(filme);

        patch.ApplyTo(filmeParaAtualizar, ModelState);

        if (!TryValidateModel(filmeParaAtualizar))
        {
            return ValidationProblem(ModelState);
        }

        _mapper.Map(filmeParaAtualizar, filme);

        _context.SaveChanges();

        return NoContent();
    }

    [HttpDelete("{id}")]
    public IActionResult DeletarFilme(int id)
    {
        Filme filme = _context.Filmes.FirstOrDefault(f => f.Id == id);

        if (filme == null) return NotFound();

        _context.Remove(filme);
        _context.SaveChanges();

        return NoContent();
    }
}
