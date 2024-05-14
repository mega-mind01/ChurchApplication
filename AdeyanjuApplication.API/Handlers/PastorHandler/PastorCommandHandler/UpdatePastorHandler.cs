using AdeyanjuApplication.API.Commands.PastorCommands;
using AdeyanjuApplication.API.Handlers;
using AdeyanjuApplication.DataService.Repository.Interface;
using AdeyanjuApplication.Entities.DbSet;
using AdeyanjuApplication.Entities.DTO.Response;
using AutoMapper;
using ChurchApplication.Entities.DTO.Request;
using MediatR;

namespace ChurchApplication.API.Handlers.PastorHandler.PastorCommandHandler
{
    public class UpdatePastorHandler : BaseClass, IRequestHandler<UpdatePastorInfoRequest, bool>
    {
        public UpdatePastorHandler(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
        }

        public async Task<bool> Handle(UpdatePastorInfoRequest request, CancellationToken cancellationToken)
        {
            var pastor = _mapper.Map<Pastor>(request.UpdatePastor);

            var result = await _unitOfWork.Pastor.Update(pastor);
            if (result)
            {
                await _unitOfWork.CompleteAsync();
                return true;
            }

            return false;
        }
    }
}
