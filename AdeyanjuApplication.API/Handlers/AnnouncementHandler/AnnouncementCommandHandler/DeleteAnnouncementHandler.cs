using AdeyanjuApplication.API.Handlers;
using AdeyanjuApplication.DataService.Repository.Interface;
using AutoMapper;
using ChurchApplication.API.Commands.AnnouncementCommands;
using MediatR;

namespace ChurchApplication.API.Handlers.AnnouncementHandler.AnnouncementCommandHandler
{
    public class DeleteAnnouncementHandler : BaseClass, IRequestHandler<DeleteAnnouncementInfoRequest, bool>
    {
        public DeleteAnnouncementHandler(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
        }

        public async Task<bool> Handle(DeleteAnnouncementInfoRequest request, CancellationToken cancellationToken)
        {
            var result = await _unitOfWork.Announcement.Delete(request.AnnouncementId);

            if (result)
            {
                await _unitOfWork.CompleteAsync();
                return true;
            }

            return false;
        }
    }
}
