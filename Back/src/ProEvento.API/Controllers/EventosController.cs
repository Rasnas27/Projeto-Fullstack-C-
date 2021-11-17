using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using ProEventos.Domain;
using ProEventos.Persistence;

namespace ProEvento.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventosController : ControllerBase
    {
        public ProEventosContext _context { get; }

        public EventosController(ProEventosContext context)
        {
            this._context = context;

        }

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return _context.Eventos;
        }

        [HttpGet("{id}")]
        public Evento GetByid(int id)
        {
            return _context.Eventos.FirstOrDefault(x => x.Id == id);
        }


        [HttpPost]
        public string Post(int id)
        {
            return "Exemplo de post";
        }

        [HttpPut]
        public string Put(int id)
        {
            return $"Exemplo de Put com id = {id}";
        }


    }
}
