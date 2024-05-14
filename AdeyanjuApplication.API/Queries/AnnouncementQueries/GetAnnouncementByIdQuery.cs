using AdeyanjuApplication.Entities.DTO.Response;
using MediatR;

namespace ChurchApplication.API.Queries.AnnouncementQueries
{
    public class GetAnnouncementByIdQuery : IRequest<GetAnnouncement>
    {
        public string AnnouncementId { get; }

        public GetAnnouncementByIdQuery(string Id)
        {
            AnnouncementId = Id;
        }
    }
}
