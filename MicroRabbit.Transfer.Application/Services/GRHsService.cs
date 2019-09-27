using MicroRabbit.GestionCompresseur.Application.Interfaces;
using MicroRabbit.GestionCompresseur.Domain.Interfaces;
using MicroRabbit.GestionCompresseur.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRabbit.GestionCompresseur.Application.Services
{
    public class GRHsService : IGRHsService
    {
        private readonly IGRHsRepository _gRHsRepository;
        public GRHsService(IGRHsRepository gRHsRepository)
        {
            _gRHsRepository = gRHsRepository;
        }
        public string DeleteGRH(int id)
        {
            return _gRHsRepository.DeleteGRH(id);
        }

        public GRH GetGRH(int id)
        {
            return _gRHsRepository.GetGRH(id);
        }

        public IEnumerable<GRH> GetGRHs()
        {
            return _gRHsRepository.GetGRHs();
        }

        public string PostGRH(GRH gRH)
        {
            return _gRHsRepository.PostGRH(gRH);
        }

        public string PutGRH(int id, GRH grh)
        {
            return _gRHsRepository.PutGRH(id, grh);
        }
    }
}
