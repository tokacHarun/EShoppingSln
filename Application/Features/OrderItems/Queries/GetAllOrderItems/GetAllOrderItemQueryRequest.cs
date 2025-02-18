using Application.Bases;
using MediatR;

namespace Application.Features.OrderItems.Queries.GetAllOrderItems
{
    public class GetAllOrderItemQueryRequest : IRequest<ResponseDto<IList<GetAllOrderItemQueryResponse>>>
    {
        public GetAllOrderItemQueryRequest()
        {
            
        }
    }
}
