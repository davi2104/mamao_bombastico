using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using proeventos.api.Models;

namespace proeventos.api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {

public IEnumerable<Evento> _evento = new Evento[]{
                new Evento(){
                    EventoId = 1,
                    Tema = "Angular e .NET 5",
                    Local = "SãoPaulo",
                    Lote = "Primeiro Lote",
                    QntPessoas = 250,
                    DataEvento = DateTime.Now.AddDays(2).ToString()
                },
                new Evento(){
                    EventoId = 2,
                    Tema = "Angular12 e .NET 59",
                    Local = "Rio de janeiro",
                    Lote = "Quinto Lote",
                    QntPessoas = 9082,
                    DataEvento = DateTime.Now.AddDays(5).ToString()
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

        [HttpPost]
        public string Post()
        {
            return "post works"; 
        }

        [HttpPut("{id}")]
        public string Put(int id)
        {
            return $"put works, id = {id}"; 
        }

        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return $"Delete works, id = {id}"; 
        }
    }
}
