using EventoApp.Core.Data;
using EventoApp.Core.Models;
using Microsoft.AspNetCore.Mvc;

namespace EventoApp.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class TarefasController : ControllerBase
    {
        private readonly TarefasContext _db;

        public TarefasController(TarefasContext db)
        {
            _db = db;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_db.Tarefas);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var tarefa = _db.Tarefas.Find(id);
            if (tarefa == null)
                return NotFound();
            return Ok(tarefa);
        }

        [HttpPost]
        public IActionResult Post([FromBody] ListarTarefas tarefa)
        {
            if (tarefa == null)
                return BadRequest();

            _db.Tarefas.Add(tarefa);
            _db.SaveChanges();
            return Created($"tarefas/{tarefa.id}", tarefa);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] ListarTarefas tarefa)
        {
            if (id != tarefa.id)
                return BadRequest();
            _db.Tarefas.Update(tarefa);
            _db.SaveChanges();
            return NoContent();
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var tarefa = _db.Tarefas.Find(id);
            if (tarefa == null)
                return NotFound();
            _db.Tarefas.Remove(tarefa);
            _db.SaveChanges();
            return NoContent();
        }
    }
}
