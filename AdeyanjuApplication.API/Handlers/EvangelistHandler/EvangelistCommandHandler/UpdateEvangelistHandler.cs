using AdeyanjuApplication.API.Handlers;
using AdeyanjuApplication.DataService.Repository.Interface;
using AdeyanjuApplication.Entities.DbSet;
using AutoMapper;
using ChurchApplication.API.Commands.EvangelistCommands;
using MediatR;

namespace ChurchApplication.API.Handlers.EvangelistHandler.EvangelistCommandHandler
{
    public class UpdateEvangelistHandler : BaseClass, IRequestHandler<UpdateEvangelistInfoRequest, bool>
    {
        public UpdateEvangelistHandler(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
        }

        public async Task<bool> Handle(UpdateEvangelistInfoRequest request, CancellationToken cancellationToken)
        {
            var evangelsit = _mapper.Map<Evangelist>(request.updateEvangelist);

            var result = await _unitOfWork.Evangelist.Update(evangelsit);
            
            if (result)
            {
                await _unitOfWork.CompleteAsync();
                return true;
            }

            return false;
        }
    }
}
