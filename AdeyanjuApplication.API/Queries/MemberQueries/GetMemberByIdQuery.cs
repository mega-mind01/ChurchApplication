using AdeyanjuApplication.Entities.DTO.Response;
using MediatR;

namespace ChurchApplication.API.Queries.MemberQueries
{
    public class GetMemberByIdQuery : IRequest<GetUser>
    {
        public string MemberId { get; }

        public GetMemberByIdQuery(string Id)
        {
            MemberId = Id;
        }
    }
}
