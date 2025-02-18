using Application.Bases;
using Application.Interfaces.AutoMappers;
using Application.Interfaces.UnitOfWorks;
using Domain.Entities;
using MediatR;

namespace Application.Features.Categories.Queries.GetAllCategory
{
    public class GetAllQueryCategoryHandler : BaseHandler, IRequestHandler<GetAllQueryCategoryRequest, ResponseDto<IList<GetAllQueryCategoryResponse>>>
    {
        public GetAllQueryCategoryHandler(IMapping mapping, IUnitOfWork unitOfWork) : base(mapping, unitOfWork)
        {
        }

        public async Task<ResponseDto<IList<GetAllQueryCategoryResponse>>> Handle(GetAllQueryCategoryRequest request, CancellationToken cancellationToken)
        {
            var data = await unitOfWork.GetReadRepostory<Category>().GetAllAsync(x => !x.IsDeleted);
            var mapData = _mapping.Map<GetAllQueryCategoryResponse, Category>(data);

            return new ResponseDto<IList<GetAllQueryCategoryResponse>>().Success(mapData);

        }
    }
}
