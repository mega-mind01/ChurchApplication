using AdeyanjuApplication.Entities.DTO.Response;
using MediatR;

namespace ChurchApplication.API.Queries.MemberQueries
{
    public class GetAllMemberQuery : IRequest<IEnumerable<GetUser>>
    {
    }
}
