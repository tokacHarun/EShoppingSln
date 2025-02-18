using Application.Bases;
using MediatR;

namespace Application.Features.Products.Queries.GetByIdProducts
{
    public class GetByIdProductQueryRequest : IRequest<ResponseDto<GetByIdProductQueryResponse>>
    {
        public GetByIdProductQueryRequest(int Id)
        {
            this.Id = Id;
        }

        public int Id { get; }
    }
}
