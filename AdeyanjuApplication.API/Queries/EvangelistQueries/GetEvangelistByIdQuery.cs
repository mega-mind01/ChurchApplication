using AdeyanjuApplication.Entities.DTO.Response;
using MediatR;

namespace ChurchApplication.API.Queries.EvangelistQueries
{
    public class GetEvangelistByIdQuery : IRequest<GetEvangelist>
    {
        public string evangelistId { get; }

        public GetEvangelistByIdQuery(string id)
        {
            evangelistId = id;
        }
    }
}