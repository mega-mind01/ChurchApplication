using MediatR;

namespace ChurchApplication.API.Commands.ChurchActivityCommands
{
    public class DeleteChurchActivityInfoRequest : IRequest<bool>
    {
        public string ActivityId { get; set; }

        public DeleteChurchActivityInfoRequest(string Id)
        {
            ActivityId = Id;            
        }
    }
}
