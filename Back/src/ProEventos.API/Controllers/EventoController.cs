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
    [Route("v1/[controller]")]
    public class EventoController : ControllerBase
    {

        public IEnumerable<Evento> _evento = new Evento[] {
             new Evento() {
                Id = 1,
                Local = "Selenita",
                Data = "31/12/2022",
                Nome = "EXPURGO",
                QtdPessoas = 300,
                Lote = "Primeiro lote",
                ImagemURL = "foto_inferno.png"
             },
             new Evento() {
                Id = 2,
                Local = "Escolinha Municipal Dom Joséfa",
                Data = "02/11/2022",
                Nome = "Halloween Solidário",
                QtdPessoas = 200,
                Lote = "Lote único",
                ImagemURL = "foto_prof.png"
             },
             new Evento() {
                Id = 3,
                Local = "Centro de Tradições Nordestinas",
                Data = DateTime.Now.AddDays(21).ToString("dd/MM/yyyy"),
                Nome = "CTN Apresenta: Tradições Chinesas",
                QtdPessoas = 200,
                Lote = "Terceiro lote",
                ImagemURL = "foto_baiao_cachorro.png"
             }
        };


        public EventoController()
        {

        }

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
           return _evento;
        }

        [HttpGet("{id}")]
        public IEnumerable<Evento> GetById(int id)
        {
           return _evento.Where(evento => evento.Id == id);
        }

        [HttpPost]
        public Evento Post(Evento novoEvento)
        {
            Evento eventoAlterado = new Evento() {
                Id = novoEvento.Id,
                Local = novoEvento.Local,
                Data = novoEvento.Data,
                Nome = novoEvento.Nome,
                QtdPessoas = novoEvento.QtdPessoas,
                Lote = novoEvento.Lote,
                ImagemURL = novoEvento.ImagemURL
             };

            return novoEvento;
        }

        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return $"Valor recebido via delete: {id}";
        }
    }
}
