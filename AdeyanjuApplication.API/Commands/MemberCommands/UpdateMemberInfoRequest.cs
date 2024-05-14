using ChurchApplication.Entities.DTO.Request;
using MediatR;

namespace ChurchApplication.API.Commands.MemberCommands
{
    public class UpdateMemberInfoRequest : IRequest<bool>
    {
        public UpdateUser updateNewUser { get; }

        public UpdateMemberInfoRequest(UpdateUser updateUser)
        {
            updateNewUser = updateUser;
        }
    }
}
