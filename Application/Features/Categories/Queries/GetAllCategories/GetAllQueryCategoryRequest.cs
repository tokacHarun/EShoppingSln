using Application.Bases;
using MediatR;

namespace Application.Features.Categories.Queries.GetAllCategory
{
    public class GetAllQueryCategoryRequest :IRequest<ResponseDto<IList<GetAllQueryCategoryResponse>>> 
    {
    }
}
