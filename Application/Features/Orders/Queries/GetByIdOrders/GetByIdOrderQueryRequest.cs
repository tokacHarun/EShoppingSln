using Application.Bases;
using MediatR;

namespace Application.Features.Orders.Queries.GetByIdOrders
{
    public class GetByIdOrderQueryRequest : IRequest<ResponseDto<GetByIdOrderQueryResponse>>
    {
        public GetByIdOrderQueryRequest(int id)
        {
            İd = id;
        }

        public int İd { get; }
    }
}
