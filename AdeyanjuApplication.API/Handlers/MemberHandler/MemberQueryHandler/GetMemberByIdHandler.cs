using AdeyanjuApplication.API.Handlers;
using AdeyanjuApplication.DataService.Repository.Interface;
using AdeyanjuApplication.Entities.DTO.Response;
using AutoMapper;
using ChurchApplication.API.Queries.MemberQueries;
using MediatR;

namespace ChurchApplication.API.Handlers.MemberHandler.MemberQueryHandler
{
    public class GetMemberByIdHandler : BaseClass, IRequestHandler<GetMemberByIdQuery, GetUser?>
    {
        public GetMemberByIdHandler(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
        }

        public async Task<GetUser?> Handle(GetMemberByIdQuery request, CancellationToken cancellationToken)
        {
            var user = await _unitOfWork.Member.FindById(request.MemberId);

            if (user == null)
            {
                return null;
            }

            return _mapper.Map<GetUser>(user);
        }
    }
}
