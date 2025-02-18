using Application.Bases;
using MediatR;

namespace Application.Features.Orders.Queries.GetAllOrders
{
    public class GetAllOrderQueryRequest : IRequest<ResponseDto<IList<GetAllOrderQueryResponse>>>
    {
    }
    
    
}
