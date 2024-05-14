using AdeyanjuApplication.API.Handlers;
using AdeyanjuApplication.DataService.Repository.Interface;
using AdeyanjuApplication.Entities.DbSet;
using AdeyanjuApplication.Entities.DTO.Response;
using AutoMapper;
using ChurchApplication.API.Commands.EvangelistCommands;
using MediatR;

namespace ChurchApplication.API.Handlers.EvangelistHandler.EvangelistCommandHandler
{
    public class CreateEvangelistHandler : BaseClass, IRequestHandler<CreateEvangelistInfoRequest, GetEvangelist>
    {
        public CreateEvangelistHandler(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
        }

        public async Task<GetEvangelist> Handle(CreateEvangelistInfoRequest request, CancellationToken cancellationToken)
        {

            var evangelist = _mapper.Map<Evangelist>(request.createEvangelist);

            await _unitOfWork.Evangelist.Add(evangelist);
            await _unitOfWork.CompleteAsync();

            return _mapper.Map<GetEvangelist>(evangelist);
        }
    }
}
