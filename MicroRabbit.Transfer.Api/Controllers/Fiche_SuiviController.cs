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
    public class Fiche_SuiviController : ControllerBase
    {
        private readonly IFiches_SuiviService _fiches_SuiviService;

        public Fiche_SuiviController(IFiches_SuiviService fiches_SuiviService)
        {
            _fiches_SuiviService = fiches_SuiviService;
        }

        // GET: api/Fiche_Suivi
        [HttpGet]
        public ActionResult<IEnumerable<Fiche_Suivi>> GetFiche_Suivis()
        {
            return Ok(_fiches_SuiviService.GetFiche_Suivis());
        }

        // GET: api/Fiche_Suivi/5
        [HttpGet("{id}")]
        public ActionResult<Fiche_Suivi> GetFiche_Suivi(int id)
        {
            return Ok(_fiches_SuiviService.GetFiche_Suivi(id));
        }
        // PUT: api/Fiche_Suivi/5
        [HttpPut("{id}")]
        public ActionResult<string> PutFiche_Suivi(int id, Fiche_Suivi fiche_Suivi )
        {
            return Ok(_fiches_SuiviService.PutFiche_Suivi(id, fiche_Suivi));
        }

        // POST: api/Fiche_Suivi
        [HttpPost]
        public ActionResult<string> Postfiche_Suivi(Fiche_Suivi fiche_Suivi)
        {
            return Ok(_fiches_SuiviService.PostFiche_Suivi(fiche_Suivi));
        }

        // DELETE: api/Fiche_Suivi/5
        [HttpDelete("{id}")]
        public ActionResult<string> Deletefiche_Suivi(int id)
        {
            return Ok(_fiches_SuiviService.DeleteFiche_Suivi(id));
        }
    }
}
