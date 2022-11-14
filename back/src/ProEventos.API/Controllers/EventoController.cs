using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.API.Models; 

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
        public EventoController()
        {

        }

        public IEnumerable<Evento> evento = new Evento []{
                new Evento() {
                    EventoID = 1,
                    Tema = "Angular 11 e .NET 5",
                    Local = "Curitiba",
                    DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyy"),
                    QtdPessoas = 250,
                    Lote = "1 Lote",
                    ImagemURL = "foto.png",
                },
                new Evento() {
                    EventoID = 2,
                    Tema = "Como treinar seu dragão",
                    Local = "São Paulo",
                    DataEvento = DateTime.Now.AddDays(3).ToString("dd/MM/yyy"),
                    QtdPessoas = 450,
                    Lote = "3 Lote",
                    ImagemURL = "foto2.png",
                }
            };

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return evento;
        }

        [HttpGet("{id}")]
        public IEnumerable<Evento> GetById( int id)
        {
            return evento.Where(evento => evento.EventoID == id);
        }

        [HttpPost]
        public string Post()
        {
            return "Exemplo de Post";
        }

        [HttpPut("{id}")]
        public string Put(int id)
        {
            return $"Exemplo de Put com id = {id}";
        }

        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return $"Exemplo de Delete com id = {id}";
        }
        
    }
}
