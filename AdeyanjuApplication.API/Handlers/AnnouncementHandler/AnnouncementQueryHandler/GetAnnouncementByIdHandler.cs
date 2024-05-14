using AdeyanjuApplication.API.Handlers;
using AdeyanjuApplication.DataService.Repository.Interface;
using AdeyanjuApplication.Entities.DTO.Response;
using AutoMapper;
using ChurchApplication.API.Queries.AnnouncementQueries;
using MediatR;

namespace ChurchApplication.API.Handlers.AnnouncementHandler.AnnouncementQueryHandler
{
    public class GetAnnouncementByIdHandler : BaseClass, IRequestHandler<GetAnnouncementByIdQuery, GetAnnouncement?>
    {
        public GetAnnouncementByIdHandler(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
        }

        public async Task<GetAnnouncement?> Handle(GetAnnouncementByIdQuery request, CancellationToken cancellationToken)
        {
            var announcement = await _unitOfWork.Announcement.FindById(request.AnnouncementId);

            if (announcement == null)
            {
                return null;
            }

            return _mapper.Map<GetAnnouncement>(announcement);
        }
    }
}
