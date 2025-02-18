using Application.Bases;
using MediatR;

namespace Application.Features.Categories.Queries.GetByIdCategory
{
    public class GetByIdQueryCategoryRequest:IRequest<ResponseDto<GetByIdQueryCategoryResponse>>
    {
        public GetByIdQueryCategoryRequest(int Id)
        {
            this.Id = Id;
        }

        public int Id { get; }
    }
}
