using Application.Bases;
using Application.Interfaces.AutoMappers;
using Application.Interfaces.UnitOfWorks;
using Domain.Entities;
using MediatR;

namespace Application.Features.Products.Queries.GetByIdProducts
{
    public class GetByIdProductQueryHandler : BaseHandler, IRequestHandler<GetByIdProductQueryRequest, ResponseDto<GetByIdProductQueryResponse>>
    {
        public GetByIdProductQueryHandler(IMapping mapping, IUnitOfWork unitOfWork) : base(mapping, unitOfWork)
        {
        }

        public async Task<ResponseDto<GetByIdProductQueryResponse>> Handle(GetByIdProductQueryRequest request, CancellationToken cancellationToken)
        {
            var getProduct = await unitOfWork.GetReadRepostory<Product>().GetAsync(x => x.Id == request.Id && !x.IsDeleted);

            var map = _mapping.Map<GetByIdProductQueryResponse, Product>(getProduct);

            return new ResponseDto<GetByIdProductQueryResponse>().Success(map);




        }
    }
}
