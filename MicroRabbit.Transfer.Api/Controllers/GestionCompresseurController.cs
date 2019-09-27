using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MicroRabbit.GestionCompresseur.Application.Interfaces;
using MicroRabbit.GestionCompresseur.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace MicroRabbit.GestionCompresseur.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GestionCompresseurController : ControllerBase
    {
        private readonly ICompresseurService _compresseurService;

        public GestionCompresseurController(ICompresseurService compresseurService)
        {
            _compresseurService = compresseurService;
        }

        // GET api/transfer
        [HttpGet]
        public ActionResult<IEnumerable<FournisseurDup>> Get()
        {
            return Ok(_compresseurService.GetFournisseursDup());
        }    
    }
}
