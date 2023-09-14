using FilmesApi.Models;
using Microsoft.EntityFrameworkCore;

namespace FilmesApi.Data;

public class CinemaContext : DbContext
{
    public CinemaContext(DbContextOptions<CinemaContext> opts)
        : base(opts)
    {
        
    }

    
}
