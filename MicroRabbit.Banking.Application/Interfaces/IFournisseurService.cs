using MicroRabbit.GestionFournisseur.Application.Models;
using MicroRabbit.GestionFournisseur.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRabbit.GestionFournisseur.Application.Interfaces
{
    public interface IFournisseurService
    {
        IEnumerable<Fournisseur> GetFournisseurs();
        void Creation(FournisseurCreation fournisseurCreation);
        string DeleteFournisseur(int id);

    }
}
