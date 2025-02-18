using Application.Bases;
using Application.Features.Categories.Queries.GetByIdCategories;
using Application.Features.Products.Queries.GetByIdProducts;
using Application.Interfaces.AutoMappers;
using Application.Interfaces.UnitOfWorks;
using Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Application.Features.Categories.Queries.GetByIdCategory
{
    public class GetByIdCategoryHandler : BaseHandler, IRequestHandler<GetByIdQueryCategoryRequest, ResponseDto<GetByIdQueryCategoryResponse>>
    {
        public GetByIdCategoryHandler(IMapping mapping, IUnitOfWork unitOfWork) : base(mapping, unitOfWork)
        {
        }

        public async Task<ResponseDto<GetByIdQueryCategoryResponse>> Handle(GetByIdQueryCategoryRequest request, CancellationToken cancellationToken)
        {
            var data = await unitOfWork.GetReadRepostory<Category>().GetAsync(x => x.Id == request.Id, x => x.Include(y => y.Products));

          var product=  _mapping.Map<GetProductsByCategoryIdQueryResponse, Product>(data.Products);

            var map = _mapping.Map<GetByIdQueryCategoryResponse, Category>(data);
            map.GetProducts = product;

            return new ResponseDto<GetByIdQueryCategoryResponse>().Success(map);
        }
    }
}
