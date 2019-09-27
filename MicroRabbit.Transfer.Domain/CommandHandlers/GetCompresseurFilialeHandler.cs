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
//    public class GetCompresseurFilialeHandler : IRequestHandler<GetCompresseurFilialeQuery, CompresseurFiliale>
//    {
//        private readonly ICompresseurFilialeRepository compressurFilialeRepository;
//        public GetCompresseurFilialeHandler(ICompresseurFilialeRepository compressurFilialeRepository)
//        {
//            this.compressurFilialeRepository = compressurFilialeRepository;
//        }
//        public Task<CompresseurFiliale> Handle(GetCompresseurFilialeQuery request, CancellationToken cancellationToken)
//        {
//            var result = compressurFilialeRepository.GetCompresseurFiliale(request.Id);
//            return Task.FromResult(result);
//        }
//    }
//}