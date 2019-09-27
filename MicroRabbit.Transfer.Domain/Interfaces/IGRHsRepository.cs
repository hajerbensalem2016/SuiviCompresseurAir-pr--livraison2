using MicroRabbit.GestionCompresseur.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRabbit.GestionCompresseur.Domain.Interfaces
{
    public interface IGRHsRepository
    {
        IEnumerable<GRH> GetGRHs();

        GRH GetGRH(int id);

        string PostGRH(GRH gRH);

        string DeleteGRH(int id);

        string PutGRH(int id, GRH grh);
    }
}