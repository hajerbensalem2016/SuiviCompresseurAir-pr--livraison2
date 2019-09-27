using MicroRabbit.GestionFournisseur.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRabbit.GestionFournisseur.Domain.Interfaces
{
    public interface IFournisseurRepository
    {
        IEnumerable<Fournisseur> GetFournisseurs();
        void AddF(Fournisseur fournisseur);
        string DeleteFournisseur(int id);

    }
}
