using MicroRabbit.GestionCompresseur.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MicroRabbit.GestionCompresseur.Domain.Interfaces
{
    public interface ICompresseurRepository
    {
        IEnumerable<FournisseurDup> GetFournisseur();
        void Add(FournisseurDup fournisseurDup);
    }
}
