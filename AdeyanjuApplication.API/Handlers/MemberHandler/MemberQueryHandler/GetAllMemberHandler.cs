using AdeyanjuApplication.API.Handlers;
using AdeyanjuApplication.DataService.Repository.Interface;
using AdeyanjuApplication.Entities.DTO.Response;
using AutoMapper;
using ChurchApplication.API.Queries.MemberQueries;
using MediatR;

namespace ChurchApplication.API.Handlers.MemberHandler.MemberQueryHandler
{
    public class GetAllMemberHandler : BaseClass, IRequestHandler<GetAllMemberQuery, IEnumerable<GetUser>>
    {
        public GetAllMemberHandler(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
        }

        public async Task<IEnumerable<GetUser>> Handle(GetAllMemberQuery request, CancellationToken cancellationToken)
        {
            var user = await _unitOfWork.Member.GetAll();

            if (user == null)
            {
                return Enumerable.Empty<GetUser>();
            }

            return _mapper.Map<IEnumerable<GetUser>>(user);
        }
    }
}
