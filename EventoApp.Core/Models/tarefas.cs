using System.ComponentModel.DataAnnotations;

namespace EventoApp.Core.Models;

public class ListarTarefas
{
    public int id { get; set; }

    [StringLength(255)]
    [Required]
    public string? Tarefa { get; set; }

    [StringLength(100)]
    public string? Time { get; set; }
}
