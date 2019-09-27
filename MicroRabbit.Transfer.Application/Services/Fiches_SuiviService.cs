using MicroRabbit.GestionCompresseur.Application.Interfaces;
using MicroRabbit.GestionCompresseur.Domain.Interfaces;
using MicroRabbit.GestionCompresseur.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRabbit.GestionCompresseur.Application.Services
{
    public class Fiches_SuiviService : IFiches_SuiviService
    {
        private readonly IFiches_SuiviRepository _fiches_SuiviRepository;
        public Fiches_SuiviService(IFiches_SuiviRepository fiches_SuiviRepository)
        {
            _fiches_SuiviRepository = fiches_SuiviRepository;
        }
        public string DeleteFiche_Suivi(int id)
        {
            return _fiches_SuiviRepository.DeleteFiche_Suivi(id);
        }

        public Fiche_Suivi GetFiche_Suivi(int id)
        {
            return _fiches_SuiviRepository.GetFiche_Suivi(id);
        }

        public IEnumerable<Fiche_Suivi> GetFiche_Suivis()
        {
            return _fiches_SuiviRepository.GetFiche_Suivis();
        }

        public string PostFiche_Suivi(Fiche_Suivi fiche_Suivi)
        {
            return _fiches_SuiviRepository.PostFiche_Suivi(fiche_Suivi);
        }

        public string PutFiche_Suivi(int id, Fiche_Suivi fiche_Suivi)
        {
            return _fiches_SuiviRepository.PutFiche_Suivi(id,fiche_Suivi);
        }
    }
}
