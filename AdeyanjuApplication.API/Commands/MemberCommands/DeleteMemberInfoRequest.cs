using MediatR;

namespace ChurchApplication.API.Commands.MemberCommands
{
    public class DeleteMemberInfoRequest : IRequest<bool>
    {
        public string MemberId { get; }

        public DeleteMemberInfoRequest(string Id)
        {
            MemberId = Id;
        }
    }
}
