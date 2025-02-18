using Application.Bases;
using Application.Interfaces.AutoMappers;
using Application.Interfaces.UnitOfWorks;
using Domain.Entities;
using MediatR;

namespace Application.Features.OrderItems.Queries.GetByIdOrderItems
{
    public class GetByIdOrderItemQueryHandler : BaseHandler, IRequestHandler<GetByIdOrderItemQueryRequest, ResponseDto<GetByIdOrderItemQueryResponse>>
    {
        public GetByIdOrderItemQueryHandler(IMapping mapping, IUnitOfWork unitOfWork) : base(mapping, unitOfWork)
        {
        }

        public async Task<ResponseDto<GetByIdOrderItemQueryResponse>> Handle(GetByIdOrderItemQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await unitOfWork.GetReadRepostory<OrderItem>().GetAsync(x => x.Id == request.İd);
            var mapData = _mapping.Map<GetByIdOrderItemQueryResponse, OrderItem>(data);

            return new ResponseDto<GetByIdOrderItemQueryResponse>().Success(mapData);
        }
    }
}
