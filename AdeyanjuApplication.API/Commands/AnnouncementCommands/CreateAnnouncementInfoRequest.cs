using AdeyanjuApplication.Entities.DTO.Request;
using AdeyanjuApplication.Entities.DTO.Response;
using MediatR;

namespace ChurchApplication.API.Commands.AnnouncementCommands
{
    public class CreateAnnouncementInfoRequest  : IRequest<GetAnnouncement>
    {
        public CreateAnnouncement createAnnouncement {  get; }

        public CreateAnnouncementInfoRequest(CreateAnnouncement announcement)
        {
            createAnnouncement = announcement;
        }
    }
}
