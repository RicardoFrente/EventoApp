using EventoApp.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace EventoApp.Core.Data;

public class TarefasContext : DbContext
{
    public DbSet<ListarTarefas> Tarefas { get; set; } = default!;
    public TarefasContext(DbContextOptions<TarefasContext> options) : base(options) 
    {
    }
}
