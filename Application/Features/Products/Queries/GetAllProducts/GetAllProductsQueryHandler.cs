using Application.Bases;
using Application.Features.Categories.Queries.GetAllCategory;
using Application.Interfaces.AutoMappers;
using Application.Interfaces.UnitOfWorks;
using Domain.Entities;
using MediatR;

namespace Application.Features.Products.Queries.GetAllProducts
{
    public class GetAllProductsQueryHandler : BaseHandler, IRequestHandler<GetAllProductsQueryRequest, ResponseDto<IList<GetAllProductsQueryResponse>>>
    {
        public GetAllProductsQueryHandler(IMapping mapping, IUnitOfWork unitOfWork) : base(mapping, unitOfWork)
        {
        }

        public async Task<ResponseDto<IList<GetAllProductsQueryResponse>>> Handle(GetAllProductsQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await unitOfWork.GetReadRepostory<Product>().GetAllAsync(x => !x.IsDeleted);
            var mapData = _mapping.Map<GetAllProductsQueryResponse, Product>(data);

            return new ResponseDto<IList<GetAllProductsQueryResponse>>().Success(mapData);

        }
    }
}
