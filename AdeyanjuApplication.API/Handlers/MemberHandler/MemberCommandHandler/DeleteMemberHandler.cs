using AdeyanjuApplication.API.Handlers;
using AdeyanjuApplication.DataService.Repository.Interface;
using AutoMapper;
using ChurchApplication.API.Commands.MemberCommands;
using MediatR;

namespace ChurchApplication.API.Handlers.MemberHandler.MemberCommandHandler
{
    public class DeleteMemberHandler : BaseClass, IRequestHandler<DeleteMemberInfoRequest, bool>
    {
        public DeleteMemberHandler(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
        }

        public async Task<bool> Handle(DeleteMemberInfoRequest request, CancellationToken cancellationToken)
        {
            var user = await _unitOfWork.Member.Delete(request.MemberId);

            if (user)
            {
                await _unitOfWork.CompleteAsync();
                return true;
            }
            return false;
        }
    }
}
