using MicroRabbit.GestionCompresseur.Data.Context;
using MicroRabbit.GestionCompresseur.Domain.Interfaces;
using MicroRabbit.GestionCompresseur.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MicroRabbit.GestionCompresseur.Data.Repository
{
    public class CompresseurFilialeRepository : ICompresseurFilialeRepository
    {
        private readonly CompresseurDbContext _dbContext;
        public CompresseurFilialeRepository(CompresseurDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public string DeleteCompresseurFiliale(int id)
        {
            var compreseurfilale = _dbContext.CompresseurFiliales.Where(x => x.CompFilialeID == id).FirstOrDefault();
            _dbContext.CompresseurFiliales.Remove(compreseurfilale);
            if (compreseurfilale == null)
                return "Compresseur Filiale don't Exist";
            else
                return "Delete Done";
        }

        public CompresseurFiliale GetCompresseurFiliale(int id)
        {
            return _dbContext.CompresseurFiliales.Find(id);
        }

        public IEnumerable<CompresseurFiliale> GetCompresseursFiliales()
        {
            return _dbContext.CompresseurFiliales.ToList();
        }

        public string PostCompresseurFiliale(CompresseurFiliale compresseurFiliale)
        {
            _dbContext.CompresseurFiliales.Add(compresseurFiliale);
            _dbContext.SaveChanges();
            return "Added Done"+compresseurFiliale.CompFilialeID;
        }

        public string PutCompresseurFiliale(int id, CompresseurFiliale compresseurFiliale)
        {
            var entity = _dbContext.CompresseurFiliales.Find(id);
            if (entity != null)
            {
                entity.CompresseurID = compresseurFiliale.CompresseurID;
                entity.FilialeID = compresseurFiliale.FilialeID;
                entity.Name = compresseurFiliale.Name;
                entity.MontantTotal = compresseurFiliale.MontantTotal;
                entity.MontantMensuel = compresseurFiliale.MontantMensuel;
                entity.DateDebut = compresseurFiliale.DateDebut;
                entity.Duree = compresseurFiliale.Duree;
                _dbContext.SaveChanges();
                return "Update Done"+id;
            }
            else
            {
                return "Compresseur Filiale don't exist";
            }
        }
    }
}
