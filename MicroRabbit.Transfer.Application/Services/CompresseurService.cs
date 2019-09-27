using MicroRabbit.GestionCompresseur.Application.Interfaces;
using MicroRabbit.GestionCompresseur.Domain.Interfaces;
using MicroRabbit.GestionCompresseur.Domain.Models;
using MicroRabbit.Domain.Core.Bus;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRabbit.GestionCompresseur.Application.Services
{
    public class CompresseurService : ICompresseurService
    {
        private readonly ICompresseurRepository _compresseurRepository;
        private readonly IEventBus _bus;

        public CompresseurService(ICompresseurRepository compresseurRepository, IEventBus bus)
        {
            _compresseurRepository = compresseurRepository;
            _bus = bus;
        }

        public IEnumerable<FournisseurDup> GetFournisseursDup()
        {
            return _compresseurRepository.GetFournisseur();
        }
    }
}
