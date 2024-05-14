using ChurchApplication.Entities.DTO.Request;
using MediatR;

namespace AdeyanjuApplication.API.Commands.PastorCommands
{
    public class UpdatePastorInfoRequest : IRequest<bool>
    {
        public UpdatePastor UpdatePastor { get; }

        public UpdatePastorInfoRequest( UpdatePastor updatePastor)
        {
            UpdatePastor = updatePastor;
        }
    }
}
