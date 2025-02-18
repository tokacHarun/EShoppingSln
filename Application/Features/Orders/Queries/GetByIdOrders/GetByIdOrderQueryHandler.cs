using Application.Bases;
using Application.Features.Categories.Queries.GetByIdCategories;
using Application.Features.Categories.Queries.GetByIdCategory;
using Application.Interfaces.AutoMappers;
using Application.Interfaces.UnitOfWorks;
using Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Application.Features.Orders.Queries.GetByIdOrders
{
    public class GetByIdQueryHandler : BaseHandler, IRequestHandler<GetByIdOrderQueryRequest, ResponseDto<GetByIdOrderQueryResponse>>
    {
        public GetByIdQueryHandler(IMapping mapping, IUnitOfWork unitOfWork) : base(mapping, unitOfWork)
        {
        }

        public async Task<ResponseDto<GetByIdOrderQueryResponse>> Handle(GetByIdOrderQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await unitOfWork.GetReadRepostory<Order>().GetAsync(x => x.Id == request.İd);
            var mapData = _mapping.Map<GetByIdOrderQueryResponse, Order>(data);

            return new ResponseDto<GetByIdOrderQueryResponse>().Success(mapData);
        }
    }
}
