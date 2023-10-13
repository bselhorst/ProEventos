using Microsoft.AspNetCore.Mvc;
using ProEventos.API.Data;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers;

[ApiController]
// A rota está com [controller], mas podemos mudar para qualquer nome, poderia ser api/evento
[Route("api/[controller]")]
public class EventosController : ControllerBase
{
    // Deve-se iniciar o DataContext de nome _context
    private readonly DataContext _context;
    // Faz a injeção dentro do construtor
    public EventosController(DataContext context)
    {
        _context = context;       
    }
    // Rota de Get no qual retorna um IEnumerable porque é uma lista
    [HttpGet]
    public IEnumerable<Evento> Get()
    {
        // retorna o Eventos que fica dentro do DataContext.cs
        return _context.Eventos;       
    }
    // Rota de Get específica que retorna apenas um Evento pelo Id
    [HttpGet("{id}")]
    public Evento GetById(int id)
    {
        // Retorna o evento trazendo apenas um
        return _context.Eventos.FirstOrDefault(evento => evento.EventoId == id);       
    }
}
