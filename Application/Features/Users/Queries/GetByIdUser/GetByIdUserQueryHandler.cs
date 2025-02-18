using Application.Bases;
using Application.Interfaces.AutoMappers;
using Application.Interfaces.UnitOfWorks;
using Domain.Entities;
using MediatR;

namespace Application.Features.Users.Queries.GetByIdUser
{
    public class GetByIdUserQueryHandler : BaseHandler, IRequestHandler<GetByIdUserQueryRequest, ResponseDto<GetByIdUserQueryResponse>>
    {
        public GetByIdUserQueryHandler(IMapping mapping, IUnitOfWork unitOfWork) : base(mapping, unitOfWork)
        {
        }

        public async Task<ResponseDto<GetByIdUserQueryResponse>> Handle(GetByIdUserQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await unitOfWork.GetReadRepostory<User>().GetAsync(x => x.Id == request.Id);
            var mapData = _mapping.Map<GetByIdUserQueryResponse, User>(data);
            return new ResponseDto<GetByIdUserQueryResponse>().Success(mapData);
        }
    }
}
