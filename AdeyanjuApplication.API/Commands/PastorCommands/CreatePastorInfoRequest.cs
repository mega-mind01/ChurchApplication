using AdeyanjuApplication.Entities.DTO.Request;
using AdeyanjuApplication.Entities.DTO.Response;
using MediatR;

namespace AdeyanjuApplication.API.Commands.PastorCommands
{
    public class CreatePastorInfoRequest : IRequest<GetPastor>
    {
        public CreatePastor createPastor { get; }

        public CreatePastorInfoRequest( CreatePastor pastorRequest)
        {
            createPastor = pastorRequest;
        }
    }
}
