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
//    public class CreateCompresseurFilialeHandler : IRequestHandler<CreateCompresseurFilialeCommand, string>
//    {
//        private readonly ICompresseurFilialeRepository compressurFilialeRepository;

//        public CreateCompresseurFilialeHandler(ICompresseurFilialeRepository compressurFilialeRepository)
//        {
//            this.compressurFilialeRepository = compressurFilialeRepository;
//        }

//        public Task<string> Handle(CreateCompresseurFilialeCommand request, CancellationToken cancellationToken)
//        {
//            var id = compressurFilialeRepository.PostCompresseurFiliale(request.CompresseurFiliale);
//            return Task.FromResult(id);
//        }
//    }
//}