using AdeyanjuApplication.Entities.DTO.Response;
using MediatR;

namespace ChurchApplication.API.Queries.AnnouncementQueries
{
    public class GetAllAnnouncementQuery : IRequest<IEnumerable<GetAnnouncement>>
    {
    }
}
