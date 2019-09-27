using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MicroRabbit.GestionCompresseur.Data.Context;
using MicroRabbit.GestionCompresseur.Domain.Models;
using MicroRabbit.GestionCompresseur.Application.Interfaces;

namespace MicroRabbit.GestionCompresseur.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConsommablesController : ControllerBase
    {
        private readonly IConsommableService _consommableService;

        public ConsommablesController(IConsommableService consommableService)
        {
            _consommableService = consommableService;
        }

        // GET: api/Consommables
        [HttpGet]
        public ActionResult<IEnumerable<Consommable>> GetConsommables()
        {
            return Ok(_consommableService.GetConsommables());
        }

        // GET: api/Consommables/5
        [HttpGet("{id}")]
        public ActionResult<CompresseurFiliale> GetConsommable(int id)
        {
            return Ok(_consommableService.GetConsommable(id));
        }
        // PUT: api/Consommables/5
        [HttpPut("{id}")]
        public ActionResult<string> PutConsommable(int id, Consommable consommable)
        {
            return Ok(_consommableService.PutConsommable(id, consommable));
        }

        // POST: api/Consommables
        [HttpPost]
        public ActionResult<string> PostConsommable(Consommable consommable)
        {
            return Ok(_consommableService.PostConsommable(consommable));
        }

        // DELETE: api/Consommables/5
        [HttpDelete("{id}")]
        public ActionResult<string> DeleteConsommable(int id)
        {
            return Ok(_consommableService.DeleteConsommable(id));
        }
    }
}