using Application.Bases;
using Application.Interfaces.AutoMappers;
using Application.Interfaces.UnitOfWorks;
using Domain.Entities;
using MediatR;

namespace Application.Features.OrderItems.Commands.UpdateOrderItems
{
    public class UpdateOrderItemCommandHandler : BaseHandler, IRequestHandler<UpdateOrderItemCommandRequest, ResponseDto<UpdateOrderItemCommandResponse>>
    {
        public UpdateOrderItemCommandHandler(IMapping mapping, IUnitOfWork unitOfWork) : base(mapping, unitOfWork)
        {
        }

        public async Task<ResponseDto<UpdateOrderItemCommandResponse>> Handle(UpdateOrderItemCommandRequest request, CancellationToken cancellationToken)
        {
            var data = _mapping.Map<OrderItem>(request);
            unitOfWork.OpenTransactionAsync();
            var updateData = unitOfWork.GetWriteRepository<OrderItem>().UpdateAsync(data);
            await unitOfWork.SaveAsync();
            await unitOfWork.CommitAsync();
            return new ResponseDto<UpdateOrderItemCommandResponse>().Success();
        }
    }
}
