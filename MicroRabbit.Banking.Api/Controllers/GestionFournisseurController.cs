using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MicroRabbit.GestionFournisseur.Application.Interfaces;
using MicroRabbit.GestionFournisseur.Application.Models;
using MicroRabbit.GestionFournisseur.Domain.Interfaces;
using MicroRabbit.GestionFournisseur.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace MicroRabbit.GestionFournisseur.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GestionFournisseurController : ControllerBase
    {
        private readonly IFournisseurService _fournisseurService;
        private readonly IFournisseurRepository _db;

        public GestionFournisseurController(IFournisseurService fournisseurService, IFournisseurRepository db)
        {
            _fournisseurService = fournisseurService;
            _db = db;

    }
        // GET: api/GestionFournisseur
        [HttpGet]
        public ActionResult<IEnumerable<Fournisseur>> Get()
        {
            return Ok(_fournisseurService.GetFournisseurs());
        }

        [HttpPost]
        public IActionResult Post([FromBody] FournisseurCreation fournisseurCreation)
        {

            _fournisseurService.Creation(fournisseurCreation);
            _db.AddF(new Fournisseur()
            {
                FournisseurID = fournisseurCreation.FournisseurID,
                Nom = fournisseurCreation.Nom,
                Adresse = fournisseurCreation.Adresse,
                Email = fournisseurCreation.Email
            });
            return Ok(fournisseurCreation);

        }
        [HttpDelete("{id}")]
        public ActionResult<string> DeleteFournisseur(int id)
        {
            return Ok(_fournisseurService.DeleteFournisseur(id));
        }
       
    }
}
