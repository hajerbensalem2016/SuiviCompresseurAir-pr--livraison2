//using MediatR;
//using MicroRabbit.GestionCompresseur.Domain.Commands.CommandsCompresseurFiliale;
//using MicroRabbit.GestionCompresseur.Domain.Interfaces;
//using System;
//using System.Collections.Generic;
//using System.Text;
//using System.Threading;
//using System.Threading.Tasks;

//namespace MicroRabbit.GestionCompresseur.Domain.CommandHandlers
//{
//    public class PutCompresseurFilialeHandler : IRequestHandler<PutCompresseurFilialeCommand, string>
//    {
//        private readonly ICompresseurFilialeRepository compressurFilialeRepository;
//        public PutCompresseurFilialeHandler(ICompresseurFilialeRepository compressurFilialeRepository)
//        {
//            this.compressurFilialeRepository = compressurFilialeRepository;
//        }
//        public Task<string> Handle(PutCompresseurFilialeCommand request, CancellationToken cancellationToken)
//        {
//            var id = compressurFilialeRepository.PutCompresseurFiliale(request.Id, request.CompresseurFiliale);
//            return Task.FromResult(id);

//        }

//    }
//}
