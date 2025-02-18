using Application.Bases;
using Application.Interfaces.AutoMappers;
using Application.Interfaces.UnitOfWorks;
using Domain.Entities;
using MediatR;

namespace Application.Features.OrderItems.Queries.GetAllOrderItems
{
    public class GetAllOrderItemQueryHandler : BaseHandler, IRequestHandler<GetAllOrderItemQueryRequest, ResponseDto<IList<GetAllOrderItemQueryResponse>>>
    {
        public GetAllOrderItemQueryHandler(IMapping mapping, IUnitOfWork unitOfWork) : base(mapping, unitOfWork)
        {
        }

        public async Task<ResponseDto<IList<GetAllOrderItemQueryResponse>>> Handle(GetAllOrderItemQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await unitOfWork.GetReadRepostory<OrderItem>().GetAllAsync(x => !x.IsDeleted);
            var mapData = _mapping.Map<GetAllOrderItemQueryResponse, OrderItem>(data);

            return new ResponseDto<IList<GetAllOrderItemQueryResponse>>().Success(mapData);

        }
    }
}
