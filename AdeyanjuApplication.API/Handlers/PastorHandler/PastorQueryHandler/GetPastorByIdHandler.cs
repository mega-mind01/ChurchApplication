using AdeyanjuApplication.API.Queries.PastorQueries;
using AdeyanjuApplication.DataService.Repository.Interface;
using AdeyanjuApplication.Entities.DbSet;
using AdeyanjuApplication.Entities.DTO.Response;
using AutoMapper;
using MediatR;

namespace AdeyanjuApplication.API.Handlers.PastorHandler.PastorQueryHandler
{
    public class GetPastorByIdHandler : BaseClass, IRequestHandler<GetPastorByIdQuery, GetPastor?>
    {
        public GetPastorByIdHandler(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
        }

        public async Task<GetPastor?> Handle(GetPastorByIdQuery request, CancellationToken cancellationToken)
        {
            var pastor = await _unitOfWork.Pastor.FindById(request.pastorId);

            if (pastor == null)
                return null;
            
            return _mapper.Map<GetPastor>(pastor);
        }
    }
}
