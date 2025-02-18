using Application.Bases;
using MediatR;

namespace Application.Features.Addresses.Queries.GetAllAddressQuery
{
    public class GetAllAddressQueryRequest : IRequest<ResponseDto<IList<GetAllAddressQueryResponse>>>
    {
    }
}
