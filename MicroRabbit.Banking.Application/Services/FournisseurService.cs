using MicroRabbit.GestionFournisseur.Application.Interfaces;
using MicroRabbit.GestionFournisseur.Application.Models;
using MicroRabbit.GestionFournisseur.Domain.Commands;
using MicroRabbit.GestionFournisseur.Domain.Interfaces;
using MicroRabbit.GestionFournisseur.Domain.Models;
using MicroRabbit.Domain.Core.Bus;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRabbit.GestionFournisseur.Application.Services
{
    public class FournisseurService : IFournisseurService
    {
        private readonly IFournisseurRepository _fournisseurRepository;
        private readonly IEventBus _bus;

        public FournisseurService(IFournisseurRepository fournisseurRepository, IEventBus bus)
        {
            _fournisseurRepository = fournisseurRepository;
            _bus = bus;
        }

        public IEnumerable<Fournisseur> GetFournisseurs()
        {
            return _fournisseurRepository.GetFournisseurs();
        }

        public void Creation(FournisseurCreation fournisseurCreation)
        {
            var createTransferCommand = new CreateFournisseurCommand(
                    fournisseurCreation.FournisseurID,
                    fournisseurCreation.Nom,
                    fournisseurCreation.Adresse,
                    fournisseurCreation.Email
                );

            _bus.SendCommand(createTransferCommand);
        }
       

        public string DeleteFournisseur(int id)
        {
            return _fournisseurRepository.DeleteFournisseur(id);
        }
    }
}
