using MicroRabbit.Domain.Core.Bus;
using MicroRabbit.GestionCompresseur.Domain.Events;
using MicroRabbit.GestionCompresseur.Domain.Interfaces;
using MicroRabbit.GestionCompresseur.Domain.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MicroRabbit.GestionCompresseur.Domain.EventHandlers
{
    public class CreationEventHandler : IEventHandler<CreationDoneEvent>
    {
        private readonly ICompresseurRepository _compresseurRepository;

        public CreationEventHandler(ICompresseurRepository compresseurRepository)
        {
            _compresseurRepository = compresseurRepository;
        }

        public Task Handle(CreationDoneEvent @event)
        {
            _compresseurRepository.Add(new FournisseurDup()
            {
                FournisseurID = @event.FournisseurID,
                Nom = @event.Nom,
                Adresse = @event.Adresse,
                Email=@event.Email
            });

            return Task.CompletedTask;
        }
    }
}
