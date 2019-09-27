//using MediatR;
//using MicroRabbit.GestionCompresseur.Domain.Interfaces;
//using MicroRabbit.GestionCompresseur.Domain.Models;
//using MicroRabbit.GestionCompresseur.Domain.Queries;
//using System;
//using System.Collections.Generic;
//using System.Text;
//using System.Threading;
//using System.Threading.Tasks;

//namespace MicroRabbit.GestionCompresseur.Domain.CommandHandlers
//{
//    public class GetCompresseursFilialesHandler : IRequestHandler<GetCompresseursFilialesQuery, IEnumerable<CompresseurFiliale>>
//    {
//        private readonly ICompresseurFilialeRepository compressurFilialeRepository;
//        public GetCompresseursFilialesHandler(ICompresseurFilialeRepository compressurFilialeRepository)
//        {
//            this.compressurFilialeRepository = compressurFilialeRepository;
//        }
//        public Task<IEnumerable<CompresseurFiliale>> Handle(GetCompresseursFilialesQuery request, CancellationToken cancellationToken)
//        {
//            var result = compressurFilialeRepository.GetCompresseursFiliales();
//            return Task.FromResult(result);
//        }
//    }
//}
