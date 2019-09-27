using MicroRabbit.GestionCompresseur.Data.Context;
using MicroRabbit.GestionCompresseur.Domain.Interfaces;
using MicroRabbit.GestionCompresseur.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MicroRabbit.GestionCompresseur.Data.Repository
{
    public class GRHsRepository : IGRHsRepository
    {
        private readonly CompresseurDbContext _context;

        // Constructor
        public GRHsRepository(CompresseurDbContext context)
        {
            _context = context;
        }


        // CRUD
        public string DeleteGRH(int id)
        {
            var gRH = _context.GRHs.Find(id);
            _context.GRHs.Remove(gRH);
            _context.SaveChanges();

            return "Delete Done";
        }

        public GRH GetGRH(int id)
        {
            var gRH = _context.GRHs.Find(id);

            return gRH;
        }

        public IEnumerable<GRH> GetGRHs()
        {
            return _context.GRHs.ToList();
        }

        public string PostGRH(GRH gRH)
        {
            _context.GRHs.Add(gRH);
            _context.SaveChanges();

            return "Added done"+gRH.GRhID;
        }

        public string PutGRH(int id, GRH grh)
        {
            var entity = _context.GRHs.Find(id);
            if (entity != null)
            {
                entity.CompFilialeID = grh.CompFilialeID;
                entity.Charge_Compresseur = grh.Charge_Compresseur;
                entity.Charge_Secteur = grh.Charge_Secteur;
                entity.Charge_Total = grh.Charge_Total;
                entity.Compresseur_Pourcentage = grh.Compresseur_Pourcentage;
                entity.Date = grh.Date;
                entity.Nom = grh.Nom;
                entity.Salaire = grh.Salaire;
                entity.Secheur_Pourcentage = grh.Secheur_Pourcentage;

                // _context.Entry(entity).State = EntityState.Modified;
                _context.SaveChanges();
                return "Update Done" +grh.GRhID;
            }
            else
            {
                return "GRh don't Exist";
            }
        }
    }
}
