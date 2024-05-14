using AdeyanjuApplication.API.Handlers;
using AdeyanjuApplication.DataService.Repository.Interface;
using AdeyanjuApplication.Entities.DbSet;
using AutoMapper;
using ChurchApplication.API.Commands.ChurchActivityCommands;
using MediatR;

namespace ChurchApplication.API.Handlers.ChurchActivityHandler.ChurchActivityCommandHandler
{
    public class UpdateChurchActivityHandler : BaseClass, IRequestHandler<UpdateChurchActivityInfoRequest, bool>
    {
        public UpdateChurchActivityHandler(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
        }

        public async Task<bool> Handle(UpdateChurchActivityInfoRequest request, CancellationToken cancellationToken)
        {
            var churchActivity = _mapper.Map<ChurchActivity>(request.churchActivity);

            await _unitOfWork.ChurchActivity.Update(churchActivity);
            await _unitOfWork.CompleteAsync();

            return true;
        }
    }
}
