using MicroRabbit.GestionCompresseur.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRabbit.GestionCompresseur.Domain.Interfaces
{
    public interface IFiches_SuiviRepository
    {
        IEnumerable<Fiche_Suivi> GetFiche_Suivis();

        Fiche_Suivi GetFiche_Suivi(int id);

        string PostFiche_Suivi(Fiche_Suivi fiche_Suivi);

        string DeleteFiche_Suivi(int id);

        string PutFiche_Suivi(int id, Fiche_Suivi fiche_Suivi);
    }
}
