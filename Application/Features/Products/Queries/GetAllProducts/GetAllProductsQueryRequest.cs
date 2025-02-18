using Application.Bases;
using MediatR;

namespace Application.Features.Products.Queries.GetAllProducts
{
    public class GetAllProductsQueryRequest : IRequest<ResponseDto<IList<GetAllProductsQueryResponse>>>
    {
    }
}
