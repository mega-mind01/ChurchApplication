using AdeyanjuApplication.Entities.DTO.Request;
using AdeyanjuApplication.Entities.DTO.Response;
using MediatR;

namespace ChurchApplication.API.Commands.EvangelistCommands
{
    public class CreateEvangelistInfoRequest : IRequest<GetEvangelist>
    {
        public CreateEvangelist createEvangelist {  get; }

        public CreateEvangelistInfoRequest(CreateEvangelist evangelist)
        {
            createEvangelist = evangelist;
        }
    }
}
