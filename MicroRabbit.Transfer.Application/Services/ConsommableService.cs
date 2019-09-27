using MicroRabbit.GestionCompresseur.Application.Interfaces;
using MicroRabbit.GestionCompresseur.Domain.Interfaces;
using MicroRabbit.GestionCompresseur.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRabbit.GestionCompresseur.Application.Services
{
    public class ConsommableService : IConsommableService
    {
        private readonly IConsommablesRepository _consommablesRepository;
        public ConsommableService(IConsommablesRepository consommablesRepository)
        {
            _consommablesRepository = consommablesRepository;
        }
        public string DeleteConsommable(int id)
        {
            return _consommablesRepository.DeleteConsommable(id);
        }

        public Consommable GetConsommable(int id)
        {
            return _consommablesRepository.GetConsommable(id);
        }

        public IEnumerable<Consommable> GetConsommables()
        {
            return _consommablesRepository.GetConsommables();
        }

        public string PostConsommable(Consommable consommable)
        {
            return _consommablesRepository.PostConsommable(consommable);
        }

        public string PutConsommable(int id, Consommable consommable)
        {
            return _consommablesRepository.PutConsommable(id, consommable);
        }
    }
}
