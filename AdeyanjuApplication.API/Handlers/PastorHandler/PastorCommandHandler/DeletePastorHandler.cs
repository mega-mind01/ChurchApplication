using AdeyanjuApplication.API.Handlers;
using AdeyanjuApplication.DataService.Repository.Interface;
using AutoMapper;
using ChurchApplication.API.Commands.PastorCommands;
using MediatR;

namespace ChurchApplication.API.Handlers.PastorHandler.PastorCommandHandler
{
    public class DeletePastorHandler : BaseClass, IRequestHandler<DeletePastorInfoRequest, bool>
    {
        public DeletePastorHandler(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
        }

        public async Task<bool> Handle(DeletePastorInfoRequest request, CancellationToken cancellationToken)
        {
            var result = await _unitOfWork.Pastor.Delete(request.pastorId);

            if (result)
            {
                await _unitOfWork.CompleteAsync();
                return true;
            }

            return false;
        }
    }
}
