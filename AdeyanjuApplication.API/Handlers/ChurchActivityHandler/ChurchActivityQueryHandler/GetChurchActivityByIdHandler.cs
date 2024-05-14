using AdeyanjuApplication.API.Handlers;
using AdeyanjuApplication.DataService.Repository.Interface;
using AdeyanjuApplication.Entities.DTO.Response;
using AutoMapper;
using ChurchApplication.API.Queries.ChurchActivityQueries;
using MediatR;

namespace ChurchApplication.API.Handlers.ChurchActivityHandler.ChurchActivityQueryHandler
{
    public class GetChurchActivityByIdHandler : BaseClass, IRequestHandler<GetChurchActivityByIdQuery, GetChurchActivity?>
    {
        public GetChurchActivityByIdHandler(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
        }

        public async Task<GetChurchActivity?> Handle(GetChurchActivityByIdQuery request, CancellationToken cancellationToken)
        {
            var churchActivity = await _unitOfWork.ChurchActivity.FindById(request.churchActivityId);

            if (churchActivity == null)
            {
                return null;
            }

            return _mapper.Map<GetChurchActivity>(churchActivity);
        }
    }
}
