using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using proeventos.api.Data;
using proeventos.api.Models;

namespace proeventos.api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
        private readonly DataContext context;
        public EventoController(DataContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return context.Eventos;
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
