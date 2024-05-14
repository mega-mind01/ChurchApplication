using AdeyanjuApplication.DataService.Repository.Interface;
using AutoMapper;

namespace AdeyanjuApplication.API.Handlers
{
    public class BaseClass
    {
        protected readonly IUnitOfWork _unitOfWork;
        protected readonly IMapper _mapper;

        public BaseClass(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }
    }
}
