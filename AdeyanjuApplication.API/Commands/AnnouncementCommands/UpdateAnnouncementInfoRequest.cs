using ChurchApplication.Entities.DTO.Request;
using MediatR;

namespace ChurchApplication.API.Commands.AnnouncementCommands
{
    public class UpdateAnnouncementInfoRequest : IRequest<bool>
    {
        public UpdateAnnouncement UpdateAnnouncement { get; }

        public UpdateAnnouncementInfoRequest(UpdateAnnouncement announcement)
        {
            UpdateAnnouncement = announcement;
        }
    }
}
