using AdeyanjuApplication.Entities.DTO.Response;
using MediatR;

namespace ChurchApplication.API.Queries.ChurchActivityQueries
{
    public class GetChurchActivityByIdQuery : IRequest<GetChurchActivity>
    {
        public string churchActivityId { get; }

        public GetChurchActivityByIdQuery(string Id)
        {
            churchActivityId = Id;
        }
    }
}
