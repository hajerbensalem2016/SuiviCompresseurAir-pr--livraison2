using MicroRabbit.GestionCompresseur.Application.Interfaces;
using MicroRabbit.GestionCompresseur.Data.Repository;
using MicroRabbit.GestionCompresseur.Domain.Interfaces;
using MicroRabbit.GestionCompresseur.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRabbit.GestionCompresseur.Application.Services
{
    public class CompresseurFilialeService : ICompresseurFilialeService
    {
        private readonly ICompresseurFilialeRepository _compresseurFilialeRepository;
        public CompresseurFilialeService(ICompresseurFilialeRepository compresseurFilialeRepository)
        {
            _compresseurFilialeRepository = compresseurFilialeRepository;
        }

        public string DeleteCompresseurFiliale(int id)
        {

            return _compresseurFilialeRepository.DeleteCompresseurFiliale(id);
        }

        public CompresseurFiliale GetCompresseurFiliale(int id)
        {
            return _compresseurFilialeRepository.GetCompresseurFiliale(id);
        }

        public IEnumerable<CompresseurFiliale> GetCompresseursFiliales()
        {
            return _compresseurFilialeRepository.GetCompresseursFiliales();
        }

        public string PostCompresseurFiliale(CompresseurFiliale compresseurFiliale)
        {
            return _compresseurFilialeRepository.PostCompresseurFiliale(compresseurFiliale);
        }

        public string PutCompresseurFiliale(int id, CompresseurFiliale compresseurFiliale)
        {
            return _compresseurFilialeRepository.PutCompresseurFiliale(id, compresseurFiliale);
        }
    }
}
