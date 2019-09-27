using MicroRabbit.GestionCompresseur.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRabbit.GestionCompresseur.Domain.Interfaces
{
    public interface ICompresseurFilialeRepository
    {
        IEnumerable<CompresseurFiliale> GetCompresseursFiliales();

        CompresseurFiliale GetCompresseurFiliale(int id);

        string PostCompresseurFiliale(CompresseurFiliale compresseurFiliale);

        string DeleteCompresseurFiliale(int id);
        string PutCompresseurFiliale(int id, CompresseurFiliale compresseurFiliale);
    }
}
