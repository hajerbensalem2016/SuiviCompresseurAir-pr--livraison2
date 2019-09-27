using MediatR;
using MicroRabbit.GestionFournisseur.Application.Interfaces;
using MicroRabbit.GestionFournisseur.Application.Services;
using MicroRabbit.GestionFournisseur.Data.Context;
using MicroRabbit.GestionFournisseur.Data.Repository;
using MicroRabbit.GestionFournisseur.Domain.CommandHandlers;
using MicroRabbit.GestionFournisseur.Domain.Commands;
using MicroRabbit.GestionFournisseur.Domain.Interfaces;
using MicroRabbit.Domain.Core.Bus;
using MicroRabbit.Infra.Bus;
using MicroRabbit.GestionCompresseur.Application.Interfaces;
using MicroRabbit.GestionCompresseur.Application.Services;
using MicroRabbit.GestionCompresseur.Data.Context;
using MicroRabbit.GestionCompresseur.Data.Repository;
using MicroRabbit.GestionCompresseur.Domain.EventHandlers;
using MicroRabbit.GestionCompresseur.Domain.Events;
using MicroRabbit.GestionCompresseur.Domain.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRabbit.Infra.IoC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            //Domain Bus
            services.AddSingleton<IEventBus, RabbitMQBus>(sp =>
            {
                var scopeFactory = sp.GetRequiredService<IServiceScopeFactory>();
                return new RabbitMQBus(sp.GetService<IMediator>(), scopeFactory);
            });

            //Subscriptions
            services.AddTransient<CreationEventHandler>();

            //Domain Events
            services.AddTransient<IEventHandler<CreationDoneEvent>, CreationEventHandler>();

            //Domain Banking Commands
            services.AddTransient<IRequestHandler<CreateFournisseurCommand, bool>, FournisseurCommandHandler>();

            //Application Services
            services.AddTransient<IFournisseurService, FournisseurService>();
            services.AddTransient<ICompresseurService, CompresseurService>();
            services.AddTransient<ICompresseurFilialeService, CompresseurFilialeService>();
            services.AddTransient<IConsommableService, ConsommableService>();
            services.AddTransient<IFiches_SuiviService, Fiches_SuiviService>();
            services.AddTransient<IGRHsService, GRHsService>();

            //Data
            services.AddTransient<IFournisseurRepository, FournisseurRepository>();
            services.AddTransient<ICompresseurRepository, CompresseurRepository>();
            services.AddTransient<ICompresseurFilialeRepository, CompresseurFilialeRepository>();
            services.AddTransient<IConsommablesRepository, ConsommablesRepository>();
            services.AddTransient<IFiches_SuiviRepository, Fiches_SuiviRepository>();
            services.AddTransient<IGRHsRepository, GRHsRepository>();
            services.AddTransient<FournisseurDbContext>();
            services.AddTransient<CompresseurDbContext>();
        }
    }
}
