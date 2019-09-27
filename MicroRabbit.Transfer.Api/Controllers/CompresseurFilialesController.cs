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
    [ApiExplorerSettings(IgnoreApi = true)]
    public class CompresseurFilialesController : ControllerBase
    {
        private readonly ICompresseurFilialeService _compresseurFilialeService;
        public CompresseurFilialesController(ICompresseurFilialeService compresseurFilialeService)
        {
            _compresseurFilialeService = compresseurFilialeService;
        }

        // GET: api/CompresseurFiliales
        [HttpGet]
        public ActionResult<IEnumerable<CompresseurFiliale>> GetCompresseursFiliales()
        {
            return Ok(_compresseurFilialeService.GetCompresseursFiliales());
        }

        // GET: api/CompresseurFiliales/5
        [HttpGet("{id}")]
        public ActionResult<CompresseurFiliale> GetCompresseurFiliale(int id)
        {
            return Ok(_compresseurFilialeService.GetCompresseurFiliale(id));
        }

        // PUT: api/CompresseurFiliales/5
        [HttpPut("{id}")]
        public ActionResult<string>PutCompresseurFiliale(int id, CompresseurFiliale compresseurFiliale)
        {
            return Ok(_compresseurFilialeService.PutCompresseurFiliale(id, compresseurFiliale));
        }

        // POST: api/CompresseurFiliales
        [HttpPost]
        public ActionResult<string> PostCompresseurFiliale(CompresseurFiliale compresseurFiliale)
        {
            return Ok(_compresseurFilialeService.PostCompresseurFiliale(compresseurFiliale));
        }

        // DELETE: api/CompresseurFiliales/5
        [HttpDelete("{id}")]
        public ActionResult<string> DeleteCompresseurFiliale(int id)
        {
            return Ok(_compresseurFilialeService.DeleteCompresseurFiliale(id));
        }

        
    }
}
