using AdeyanjuApplication.API.Handlers;
using AdeyanjuApplication.DataService.Repository.Interface;
using AutoMapper;
using ChurchApplication.API.Commands.EvangelistCommands;
using MediatR;

namespace ChurchApplication.API.Handlers.EvangelistHandler.EvangelistCommandHandler
{
    public class DeleteEvangelistHandler : BaseClass, IRequestHandler<DeleteEvangelistInfoRequest, bool>
    {
        public DeleteEvangelistHandler(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
        }

        public async Task<bool> Handle(DeleteEvangelistInfoRequest request, CancellationToken cancellationToken)
        {
            var evangelist = await _unitOfWork.Evangelist.Delete(request.evangelistId);

            if (evangelist)
            {
                await _unitOfWork.CompleteAsync();
                return true;
            }
            return false;
        }
    }
}
