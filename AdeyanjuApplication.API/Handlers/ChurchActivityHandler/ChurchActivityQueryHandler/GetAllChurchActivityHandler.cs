using AdeyanjuApplication.API.Handlers;
using AdeyanjuApplication.DataService.Repository.Interface;
using AdeyanjuApplication.Entities.DTO.Response;
using AutoMapper;
using ChurchApplication.API.Queries.ChurchActivityQueries;
using MediatR;

namespace ChurchApplication.API.Handlers.ChurchActivityHandler.ChurchActivityQueryHandler
{
    public class GetAllChurchActivityHandler : BaseClass, IRequestHandler<GetAllChurchActivityQuery, IEnumerable<GetChurchActivity>>
    {
        public GetAllChurchActivityHandler(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
        }

        public async Task<IEnumerable<GetChurchActivity>> Handle(GetAllChurchActivityQuery request, CancellationToken cancellationToken)
        {
            var churchActivity = await _unitOfWork.ChurchActivity.GetAll();

            if (churchActivity == null)
            {
                return Enumerable.Empty<GetChurchActivity>();
            }

            return _mapper.Map<IEnumerable<GetChurchActivity>>(churchActivity);
        }
    }
}
