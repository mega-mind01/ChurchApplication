using AdeyanjuApplication.Entities.DTO.Request;
using AdeyanjuApplication.Entities.DTO.Response;
using MediatR;

namespace ChurchApplication.API.Commands.ChurchActivityCommands
{
    public class CreateChurchActivityInfoRequest : IRequest<GetChurchActivity>
    {
        public CreateChurchActivity churchActivity {  get; }

        public CreateChurchActivityInfoRequest(CreateChurchActivity createActivity)
        {
            churchActivity = createActivity;            
        }
    }
}
