using AdeyanjuApplication.API.Queries.PastorQueries;
using AdeyanjuApplication.DataService.Repository.Interface;
using AdeyanjuApplication.Entities.DbSet;
using AdeyanjuApplication.Entities.DTO.Response;
using AutoMapper;
using MediatR;

namespace AdeyanjuApplication.API.Handlers.PastorHandler.PastorQueryHandler
{
    public class GetAllPastorHandler : BaseClass, IRequestHandler<GetAllPastorQuery, IEnumerable<GetPastor>>
    {
        public GetAllPastorHandler(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
        }

        public async Task<IEnumerable<GetPastor>> Handle(GetAllPastorQuery request, CancellationToken cancellationToken)
        {
            var pastors = await _unitOfWork.Pastor.GetAll();
            if (pastors == null)
                return Enumerable.Empty<GetPastor>();

            return _mapper.Map<IEnumerable<GetPastor>>(pastors);
        }
    }
}
