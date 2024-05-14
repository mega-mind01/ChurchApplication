using AdeyanjuApplication.API.Commands.PastorCommands;
using AdeyanjuApplication.API.Handlers;
using AdeyanjuApplication.DataService.Repository.Interface;
using AdeyanjuApplication.Entities.DbSet;
using AdeyanjuApplication.Entities.DTO.Response;
using AutoMapper;
using MediatR;

namespace ChurchApplication.API.Handlers.PastorHandler.PastorCommandHandler
{
    public class CreatePastorHandler : BaseClass, IRequestHandler<CreatePastorInfoRequest, GetPastor>
    {
        public CreatePastorHandler(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
        }

        public async Task<GetPastor> Handle(CreatePastorInfoRequest request, CancellationToken cancellationToken)
        {
            var pastor = _mapper.Map<Pastor>(request.createPastor);

            await _unitOfWork.Pastor.Add(pastor);
            await _unitOfWork.CompleteAsync();

            return _mapper.Map<GetPastor>(pastor);
        }
    }
}
