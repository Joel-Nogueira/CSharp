using AutoMapper;
using FilmesApi.Data;
using FilmesApi.Data.Dtos;
using FilmesApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace FilmesApi.Controllers;

[ApiController]
[Route("[controller]")]
public class EnderecoController : ControllerBase
{
    private FilmeContext _context;
    private IMapper _mapper;

    public EnderecoController(FilmeContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    [HttpPost]
    public IActionResult AdicionarEndereco([FromBody] CreateEnderecoDto enderecoDto)
    {
        Endereco endereco = _mapper.Map<Endereco>(enderecoDto);
        _context.Enderecos.Add(endereco);
        _context.SaveChanges();
        return CreatedAtAction(nameof(RecuperarEnderecoPorId), 
            new { id = endereco.Id},
            endereco);
    }

    [HttpGet("{id}")]
    public IActionResult RecuperarEnderecoPorId(int id)
    {
        Endereco endereco = _context.Enderecos.FirstOrDefault(e => e.Id == id);

        if (endereco == null)
            return NotFound();

        ReadEnderecoDto enderecoDto = _mapper.Map<ReadEnderecoDto>(endereco);

        return Ok(enderecoDto);
    }

    [HttpGet]
    public IEnumerable<ReadEnderecoDto> RecuperarTodosEnderecos()
    {
        List<Endereco> enderecos = _context.Enderecos.ToList();
        List<ReadEnderecoDto> enderecosDto = _mapper.Map<List<ReadEnderecoDto>>(enderecos);
        return enderecosDto;
    }

    [HttpPut("{id}")]
    public IActionResult AtualizarEndereco(int id, [FromBody] UpdateEnderecoDto enderecoDto)
    {
        Endereco endereco = _context.Enderecos.FirstOrDefault(e => e.Id == id);

        if (endereco == null)
            return NotFound();

        _mapper.Map(enderecoDto, endereco);

        _context.SaveChanges();

        return NoContent();
    }

    [HttpDelete("{id}")]
    public IActionResult DeletarEndereco(int id)
    {
        Endereco endereco = _context.Enderecos.FirstOrDefault(e => e.Id == id);

        if (endereco == null) return NotFound();

        _context.Remove(endereco);
        _context.SaveChanges();
        return NoContent();
    }
}
