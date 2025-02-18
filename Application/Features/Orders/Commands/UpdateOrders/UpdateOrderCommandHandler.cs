using Application.Bases;
using Application.Interfaces.AutoMappers;
using Application.Interfaces.UnitOfWorks;
using Domain.Entities;
using MediatR;

namespace Application.Features.Orders.Commands.UpdateOrders
{
    public class UpdateOrderCommandHandler : BaseHandler, IRequestHandler<UpdateOrderCommandRequest, ResponseDto<UpdateOrderCommandResponse>>
    {
        public UpdateOrderCommandHandler(IMapping mapping, IUnitOfWork unitOfWork) : base(mapping, unitOfWork)
        {
        }

        public async Task<ResponseDto<UpdateOrderCommandResponse>> Handle(UpdateOrderCommandRequest request, CancellationToken cancellationToken)
        {
            var mapData = _mapping.Map<Order, UpdateOrderCommandRequest>(request);
            unitOfWork.OpenTransactionAsync();
            var updateData = unitOfWork.GetWriteRepository<Order>().UpdateAsync(mapData);
            await unitOfWork.SaveAsync();
            await unitOfWork.CommitAsync();
            return new ResponseDto<UpdateOrderCommandResponse>().Success();
        }
    }
}
