using AdeyanjuApplication.API.Handlers;
using AdeyanjuApplication.DataService.Repository.Interface;
using AdeyanjuApplication.Entities.DbSet;
using AdeyanjuApplication.Entities.DTO.Response;
using AutoMapper;
using ChurchApplication.API.Commands.AnnouncementCommands;
using MediatR;

namespace ChurchApplication.API.Handlers.AnnouncementHandler.AnnouncementCommandHandler
{
    public class CreateAnnouncementHandler : BaseClass, IRequestHandler<CreateAnnouncementInfoRequest, GetAnnouncement>
    {
        public CreateAnnouncementHandler(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
        }

        public async Task<GetAnnouncement> Handle(CreateAnnouncementInfoRequest request, CancellationToken cancellationToken)
        {
            var announcement = _mapper.Map<Announcement>(request.createAnnouncement);

            await _unitOfWork.Announcement.Add(announcement);
            await _unitOfWork.CompleteAsync();

            return _mapper.Map<GetAnnouncement>(announcement);
        }
    }
}
