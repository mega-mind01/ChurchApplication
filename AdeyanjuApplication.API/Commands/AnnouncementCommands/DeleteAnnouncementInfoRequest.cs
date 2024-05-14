using MediatR;

namespace ChurchApplication.API.Commands.AnnouncementCommands
{
    public class DeleteAnnouncementInfoRequest : IRequest<bool>
    {
        public string AnnouncementId { get; }

        public DeleteAnnouncementInfoRequest(string Id)
        {
            AnnouncementId = Id;            
        }
    }
}
