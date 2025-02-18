using Application.Bases;
using Application.Features.Categories.Queries.GetAllCategory;
using Application.Interfaces.AutoMappers;
using Application.Interfaces.UnitOfWorks;
using Domain.Entities;
using MediatR;

namespace Application.Features.Orders.Queries.GetAllOrders
{
    public class GetAllOrderQueryHandler : BaseHandler, IRequestHandler<GetAllOrderQueryRequest, ResponseDto<IList<GetAllOrderQueryResponse>>>
    {
        public GetAllOrderQueryHandler(IMapping mapping, IUnitOfWork unitOfWork) : base(mapping, unitOfWork)
        {
        }

        public async Task<ResponseDto<IList<GetAllOrderQueryResponse>>> Handle(GetAllOrderQueryRequest request, CancellationToken cancellationToken)
        {
            var datass = await unitOfWork.GetReadRepostory<Order>().GetAllAsync(x => !x.IsDeleted);

            var mapData = _mapping.Map<GetAllOrderQueryResponse, Order>(datass);

            return new ResponseDto<IList<GetAllOrderQueryResponse>>().Success(mapData);
        }
    }
}
