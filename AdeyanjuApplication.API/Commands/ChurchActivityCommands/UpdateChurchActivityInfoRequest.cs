using ChurchApplication.Entities.DTO.Request;
using MediatR;

namespace ChurchApplication.API.Commands.ChurchActivityCommands
{
    public class UpdateChurchActivityInfoRequest : IRequest<bool>
    {
        public UpdateChurchActivity churchActivity {  get; }

        public UpdateChurchActivityInfoRequest(UpdateChurchActivity activity)
        {
            churchActivity = activity;
        }
    }
}
