using AdeyanjuApplication.API.Handlers;
using AdeyanjuApplication.DataService.Repository.Interface;
using AdeyanjuApplication.Entities.DbSet;
using AdeyanjuApplication.Entities.DTO.Response;
using AutoMapper;
using ChurchApplication.API.Commands.MemberCommands;
using MediatR;

namespace ChurchApplication.API.Handlers.MemberHandler.MemberCommandHandler
{
    public class CreateMemberHandler : BaseClass, IRequestHandler<CreateMemberInfoRequest, GetUser>
    {
        public CreateMemberHandler(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
        }

        public async Task<GetUser> Handle(CreateMemberInfoRequest request, CancellationToken cancellationToken)
        {
            var user = _mapper.Map<Members>(request.CreateNewUser);

            await _unitOfWork.Member.Add(user);
            await _unitOfWork.CompleteAsync();

            return _mapper.Map<GetUser>(user);
        }
    }
}
