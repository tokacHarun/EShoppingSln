using Application.Bases;
using MediatR;

namespace Application.Features.Addresses.Queries.GetByIdAddressQuery
{
    public class GetByIdAddressQueryRequest : IRequest<ResponseDto<GetByIdAddressQueryResponse>>
    {
        public GetByIdAddressQueryRequest(int id)
        {
            Id = id;
        }

        public int Id { get; }
    }
}
