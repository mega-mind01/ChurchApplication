using AdeyanjuApplication.API.Handlers;
using AdeyanjuApplication.DataService.Repository.Interface;
using AdeyanjuApplication.Entities.DbSet;
using AutoMapper;
using ChurchApplication.API.Commands.AnnouncementCommands;
using MediatR;

namespace ChurchApplication.API.Handlers.AnnouncementHandler.AnnouncementCommandHandler
{
    public class UpdateAnnouncementHandler : BaseClass, IRequestHandler<UpdateAnnouncementInfoRequest, bool>
    {
        public UpdateAnnouncementHandler(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
        }

        public async Task<bool> Handle(UpdateAnnouncementInfoRequest request, CancellationToken cancellationToken)
        {
            var announcement = _mapper.Map<Announcement>(request.UpdateAnnouncement);

            var result = await _unitOfWork.Announcement.Update(announcement);
            if (result)
            {
                await _unitOfWork.CompleteAsync();
                return true;
            }

            return false;
        }
    }
}
