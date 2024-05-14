using AdeyanjuApplication.Entities.DTO.Response;
using MediatR;

namespace ChurchApplication.API.Queries.ChurchActivityQueries
{
    public class GetAllChurchActivityQuery : IRequest<IEnumerable<GetChurchActivity>>
    {
    }
}
