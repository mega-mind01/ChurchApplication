using MediatR;

namespace ChurchApplication.API.Commands.PastorCommands
{
    public class DeletePastorInfoRequest : IRequest<bool>
    {
        public string pastorId { get; set; }

        public DeletePastorInfoRequest(string Id)
        {
            pastorId = Id;
        }
    }
}
