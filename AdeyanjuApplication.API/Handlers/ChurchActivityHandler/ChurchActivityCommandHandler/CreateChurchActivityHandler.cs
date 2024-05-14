using AdeyanjuApplication.API.Handlers;
using AdeyanjuApplication.DataService.Repository.Interface;
using AdeyanjuApplication.Entities.DbSet;
using AdeyanjuApplication.Entities.DTO.Response;
using AutoMapper;
using ChurchApplication.API.Commands.ChurchActivityCommands;
using MediatR;

namespace ChurchApplication.API.Handlers.ChurchActivityHandler.ChurchActivityCommandHandler
{
    public class CreateChurchActivityHandler : BaseClass, IRequestHandler<CreateChurchActivityInfoRequest, GetChurchActivity>
    {
        public CreateChurchActivityHandler(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
        }

        public async Task<GetChurchActivity> Handle(CreateChurchActivityInfoRequest request, CancellationToken cancellationToken)
        {
            var churchActivity = _mapper.Map<ChurchActivity>(request.churchActivity);

            await _unitOfWork.ChurchActivity.Add(churchActivity);
            await _unitOfWork.CompleteAsync();

            return _mapper.Map<GetChurchActivity>(churchActivity);
        }
    }
}
