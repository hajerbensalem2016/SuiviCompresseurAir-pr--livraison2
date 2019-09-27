using MicroRabbit.GestionCompresseur.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRabbit.GestionCompresseur.Domain.Interfaces
{
    public interface IConsommablesRepository
    {
        IEnumerable<Consommable> GetConsommables();

        Consommable GetConsommable(int id);

        string PostConsommable(Consommable consommable);

        string DeleteConsommable(int id);

        string PutConsommable(int id, Consommable consommable);
    }
}
