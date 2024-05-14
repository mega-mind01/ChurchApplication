using AdeyanjuApplication.API.Handlers;
using AdeyanjuApplication.DataService.Repository.Interface;
using AutoMapper;
using ChurchApplication.API.Commands.ChurchActivityCommands;
using MediatR;

namespace ChurchApplication.API.Handlers.ChurchActivityHandler.ChurchActivityCommandHandler
{
    public class DeleteChurchActivityHandler : BaseClass, IRequestHandler<DeleteChurchActivityInfoRequest, bool>
    {
        public DeleteChurchActivityHandler(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
        }

        public async Task<bool> Handle(DeleteChurchActivityInfoRequest request, CancellationToken cancellationToken)
        {
            var result = await _unitOfWork.ChurchActivity.Delete(request.ActivityId);

            if (result)
            {
                await _unitOfWork.CompleteAsync();
                return true;
            }

            return false;
        }
    }
}
