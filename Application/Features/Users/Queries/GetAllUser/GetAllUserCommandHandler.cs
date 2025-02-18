using Application.Bases;
using Application.Interfaces.AutoMappers;
using Application.Interfaces.UnitOfWorks;
using Domain.Entities;
using MediatR;

namespace Application.Features.Users.Queries.GetAllUser
{
    public class GetAllUserCommandHandler : BaseHandler, IRequestHandler<GetAllUserCommandRequest, ResponseDto<IList<GetAllUserQueryResponse>>>
    {
        public GetAllUserCommandHandler(IMapping mapping, IUnitOfWork unitOfWork) : base(mapping, unitOfWork)
        {
        }

        public async Task<ResponseDto<IList<GetAllUserQueryResponse>>> Handle(GetAllUserCommandRequest request, CancellationToken cancellationToken)
        {
            var data = await unitOfWork.GetReadRepostory<User>().GetAllAsync(x => !x.IsDeleted);
            var mapData = _mapping.Map<GetAllUserQueryResponse, User>(data);
            return new ResponseDto<IList<GetAllUserQueryResponse>>().Success(mapData);
        }
    }

}
