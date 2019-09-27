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
//    public class RemoveCompresseurFilialeHandler : IRequestHandler<RemoveCompresseurFilialeCommand, string>
//    {
//        private readonly ICompresseurFilialeRepository compressurFilialeRepository;
//        public RemoveCompresseurFilialeHandler(ICompresseurFilialeRepository compressurFilialeRepository)
//        {
//            this.compressurFilialeRepository = compressurFilialeRepository;
//        }
//        public Task<string> Handle(RemoveCompresseurFilialeCommand request, CancellationToken cancellationToken)
//        {
//            var result = compressurFilialeRepository.DeleteCompresseurFiliale(request.Id);
//            return Task.FromResult(result);

//        }
//    }
//}
