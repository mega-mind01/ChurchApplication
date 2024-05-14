using AdeyanjuApplication.API.Handlers;
using AdeyanjuApplication.DataService.Repository.Interface;
using AdeyanjuApplication.Entities.DTO.Response;
using AutoMapper;
using ChurchApplication.API.Queries.AnnouncementQueries;
using MediatR;

namespace ChurchApplication.API.Handlers.AnnouncementHandler.AnnouncementQueryHandler
{
    public class GetAllAnnouncementHandler : BaseClass, IRequestHandler<GetAllAnnouncementQuery, IEnumerable<GetAnnouncement>>
    {
        public GetAllAnnouncementHandler(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
        }

        public async Task<IEnumerable<GetAnnouncement>> Handle(GetAllAnnouncementQuery request, CancellationToken cancellationToken)
        {
            var Announcements = await _unitOfWork.Announcement.GetAll();

            if (Announcements == null)
            {
                return Enumerable.Empty<GetAnnouncement>();
            }

            return _mapper.Map<IEnumerable<GetAnnouncement>>(Announcements);
        }
    }
}
