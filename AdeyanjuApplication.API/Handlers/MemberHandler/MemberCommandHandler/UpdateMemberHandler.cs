using AdeyanjuApplication.API.Handlers;
using AdeyanjuApplication.DataService.Repository.Interface;
using AdeyanjuApplication.Entities.DbSet;
using AutoMapper;
using ChurchApplication.API.Commands.MemberCommands;
using MediatR;

namespace ChurchApplication.API.Handlers.MemberHandler.MemberCommandHandler
{
    public class UpdateMemberHandler : BaseClass, IRequestHandler<UpdateMemberInfoRequest, bool>
    {
        public UpdateMemberHandler(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
        }

        public async Task<bool> Handle(UpdateMemberInfoRequest request, CancellationToken cancellationToken)
        {
            var user = _mapper.Map<Members>(request.updateNewUser);

            var result = await _unitOfWork.Member.Update(user);
            if (result)
            {
                await _unitOfWork.CompleteAsync();
                return true;
            }

            return false;
        }
    }
}
