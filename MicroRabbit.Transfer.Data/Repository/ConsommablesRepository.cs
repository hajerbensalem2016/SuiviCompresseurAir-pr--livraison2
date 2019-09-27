using MicroRabbit.GestionCompresseur.Data.Context;
using MicroRabbit.GestionCompresseur.Domain.Interfaces;
using MicroRabbit.GestionCompresseur.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MicroRabbit.GestionCompresseur.Data.Repository
{
    public class ConsommablesRepository : IConsommablesRepository
    {

        private readonly CompresseurDbContext _context;

        // Constructor
        public ConsommablesRepository(CompresseurDbContext context)
        {
            _context = context;
        }



        public string DeleteConsommable(int id)
        {
            var consommable = _context.Consommables.Find(id);
            _context.Consommables.Remove(consommable);
            _context.SaveChanges();

            return "Delete Done";
        }

        public Consommable GetConsommable(int id)
        {
            var consommable = _context.Consommables.Find(id);

            return consommable;
        }

        public IEnumerable<Consommable> GetConsommables()
        {
            return _context.Consommables.ToList();
        }

        public string PostConsommable(Consommable consommable)
        {
            _context.Consommables.Add(consommable);
            _context.SaveChanges();

            return "Added Done"+consommable.ConsommableID;
        }

        public string PutConsommable(int id, Consommable consommable)
        {
            var entity = _context.Consommables.Find(id);
            if (entity != null)
            {
                entity.CompFilialeID = consommable.CompFilialeID;
                entity.ConsommationComp = consommable.ConsommationComp;
                entity.Date = consommable.Date;
                entity.PrixUnitaire = consommable.PrixUnitaire;

                // _context.Entry(entity).State = EntityState.Modified;
                _context.SaveChanges();
                return "Update"+id;
            }
            else
            {
                return "Consommable don't exist";
            }
        }
    }
}
