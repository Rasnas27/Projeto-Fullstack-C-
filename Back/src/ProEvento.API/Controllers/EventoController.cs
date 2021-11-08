using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEvento.API.Models;

namespace ProEvento.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {

        public EventoController()
        {

        }

        public IEnumerable<Evento> _evento = new Evento[]{
                new Evento(){
                    EventoId = 1,
                    Tema = "Exercicio",
                    Local = "Brasília",
                    Lote = "primeiro lote",
                    Qtdd = 250,
                    DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy"),
                    ImagemURL = "Exemplo img"
                },
                new Evento(){
                    EventoId = 2,
                    Tema = "Exercicio 2",
                    Local = "Ceilândia",
                    Lote = "Segundo lote",
                    Qtdd = 220,
                    DataEvento = DateTime.Now.AddDays(3).ToString("dd/MM/yyyy"),
                    ImagemURL = "Exemplo img"
                }

            };

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return _evento;
        }

        [HttpGet("{id}")]
        public IEnumerable<Evento> GetByid(int id)
        {
            return _evento.Where(x => x.EventoId == id);
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
