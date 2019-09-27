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
    public class GRHsController : ControllerBase
    {
        private readonly IGRHsService _gRHsService;

        public GRHsController(IGRHsService gRHsService)
        {
            _gRHsService = gRHsService;
        }

        // GET: api/CompresseurFiliales
        [HttpGet]
        public ActionResult<IEnumerable<GRH>> GetGRHs()
        {
            return Ok(_gRHsService.GetGRHs());
        }

        // GET: api/CompresseurFiliales/5
        [HttpGet("{id}")]
        public ActionResult<CompresseurFiliale> GetGRH(int id)
        {
            return Ok(_gRHsService.GetGRH(id));
        }

        // PUT: api/CompresseurFiliales/5
        [HttpPut("{id}")]
        public ActionResult<string> PutGRH(int id, GRH gRH)
        {
            return Ok(_gRHsService.PutGRH(id, gRH));
        }

        // POST: api/CompresseurFiliales
        [HttpPost]
        public ActionResult<string> PostGRH(GRH gRH)
        {
            return Ok(_gRHsService.PostGRH(gRH));
        }

        // DELETE: api/CompresseurFiliales/5
        [HttpDelete("{id}")]
        public ActionResult<string> DeleteGRH(int id)
        {
            return Ok(_gRHsService.DeleteGRH(id));
        }


    }
}
