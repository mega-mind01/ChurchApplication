using ChurchApplication.Entities.DTO.Request;
using MediatR;

namespace ChurchApplication.API.Commands.EvangelistCommands
{
    public class UpdateEvangelistInfoRequest : IRequest<bool>
    {
        public UpdateEvangelist updateEvangelist {  get; }

        public UpdateEvangelistInfoRequest(UpdateEvangelist evangelist)
        {
            updateEvangelist = evangelist;
        }
    }
}
