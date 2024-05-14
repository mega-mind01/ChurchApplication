using AdeyanjuApplication.Entities.DTO.Request;
using AdeyanjuApplication.Entities.DTO.Response;
using MediatR;

namespace ChurchApplication.API.Commands.MemberCommands
{
    public class CreateMemberInfoRequest : IRequest<GetUser>
    {
        public CreateUser CreateNewUser { get; }

        public CreateMemberInfoRequest( CreateUser createUser)
        {
            CreateNewUser = createUser;
        }
    }
}
