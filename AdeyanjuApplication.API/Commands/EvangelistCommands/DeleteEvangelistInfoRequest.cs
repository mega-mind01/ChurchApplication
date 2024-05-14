using MediatR;

namespace ChurchApplication.API.Commands.EvangelistCommands
{
    public class DeleteEvangelistInfoRequest : IRequest<bool>
    {
        public string evangelistId { get; }

        public DeleteEvangelistInfoRequest(string Id)
        {
            evangelistId = Id;
        }
    }
}