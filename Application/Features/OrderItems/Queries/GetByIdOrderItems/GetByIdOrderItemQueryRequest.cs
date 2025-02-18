using Application.Bases;
using MediatR;

namespace Application.Features.OrderItems.Queries.GetByIdOrderItems
{
    public class GetByIdOrderItemQueryRequest : IRequest<ResponseDto<GetByIdOrderItemQueryResponse>>
    {
        public GetByIdOrderItemQueryRequest(int id)
        {
            İd = id;
        }

        public int İd { get; }
    }
}
