using AutoMapper;
using ExercicioFilmeApi.Data;
using ExercicioFilmeApi.Data.Dtos;
using ExercicioFilmeApi.Modelos;
using Microsoft.AspNetCore.Mvc;

namespace ExercicioFilmeApi.Controllers;

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
        return Ok();
    }
}
