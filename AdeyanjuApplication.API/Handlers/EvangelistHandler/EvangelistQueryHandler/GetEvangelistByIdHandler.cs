using AdeyanjuApplication.API.Handlers;
using AdeyanjuApplication.DataService.Repository.Interface;
using AdeyanjuApplication.Entities.DTO.Response;
using AutoMapper;
using ChurchApplication.API.Queries.EvangelistQueries;
using MediatR;

namespace ChurchApplication.API.Handlers.EvangelistHandler.EvangelistQueryHnadler
{
    public class GetEvangelistByIdHandler : BaseClass, IRequestHandler<GetEvangelistByIdQuery, GetEvangelist?>
    {
        public GetEvangelistByIdHandler(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
        }

        public async Task<GetEvangelist?> Handle(GetEvangelistByIdQuery request, CancellationToken cancellationToken)
        {
            var evangelist = await _unitOfWork.Evangelist.FindById(request.evangelistId);
            if (evangelist == null)
            {
                return null;
            }

            return _mapper.Map<GetEvangelist>(evangelist);
        }
    }
}
