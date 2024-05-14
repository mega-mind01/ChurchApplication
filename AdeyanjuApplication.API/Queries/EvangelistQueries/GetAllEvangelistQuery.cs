using AdeyanjuApplication.Entities.DTO.Response;
using MediatR;

namespace ChurchApplication.API.Queries.EvangelistQueries
{
    public class GetAllEvangelistQuery : IRequest<IEnumerable<GetEvangelist>>
    {
    }
}
