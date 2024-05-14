using AdeyanjuApplication.Entities.DbSet;
using AdeyanjuApplication.Entities.DTO.Response;
using MediatR;

namespace AdeyanjuApplication.API.Queries.PastorQueries
{
    public class GetAllPastorQuery : IRequest<IEnumerable<GetPastor>>
    {
    }
}
