using AdeyanjuApplication.Entities.DbSet;
using AdeyanjuApplication.Entities.DTO.Response;
using MediatR;
using System.Globalization;

namespace AdeyanjuApplication.API.Queries.PastorQueries
{
    public class GetPastorByIdQuery : IRequest<GetPastor>
    {
        public string pastorId { get; }

        public GetPastorByIdQuery(string id)
        {
            pastorId = id;
        }
    }
}
