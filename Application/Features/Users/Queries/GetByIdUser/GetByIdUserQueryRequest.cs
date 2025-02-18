using Application.Bases;
using MediatR;

namespace Application.Features.Users.Queries.GetByIdUser
{
    public class GetByIdUserQueryRequest : IRequest<ResponseDto<GetByIdUserQueryResponse>>
    {
        public GetByIdUserQueryRequest(int ıd)
        {
            Id = ıd;
        }

        public int Id { get; }
    }
}
