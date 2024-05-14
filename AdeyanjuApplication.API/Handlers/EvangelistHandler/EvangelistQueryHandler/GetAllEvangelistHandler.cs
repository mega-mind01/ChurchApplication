using AdeyanjuApplication.API.Handlers;
using AdeyanjuApplication.DataService.Repository.Interface;
using AdeyanjuApplication.Entities.DTO.Response;
using AutoMapper;
using ChurchApplication.API.Queries.EvangelistQueries;
using MediatR;

namespace ChurchApplication.API.Handlers.EvangelistHandler.EvangelistQueryHnadler
{
    public class GetAllEvangelistHandler : BaseClass, IRequestHandler<GetAllEvangelistQuery, IEnumerable<GetEvangelist>>
    {
        public GetAllEvangelistHandler(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
        }

        public async Task<IEnumerable<GetEvangelist>> Handle(GetAllEvangelistQuery request, CancellationToken cancellationToken)
        {
            var evangelists = await _unitOfWork.Evangelist.GetAll();
            if (evangelists == null)
            {
                return Enumerable.Empty<GetEvangelist>();
            }

            return _mapper.Map<IEnumerable<GetEvangelist>>(evangelists);
        }
    }
}
