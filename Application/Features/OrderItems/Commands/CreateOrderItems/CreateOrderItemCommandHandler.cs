using Application.Bases;
using Application.Interfaces.AutoMappers;
using Application.Interfaces.UnitOfWorks;
using Domain.Entities;
using MediatR;

namespace Application.Features.OrderItems.Commands.CreateOrderItems
{
    public class CreateOrderItemCommandHandler : BaseHandler, IRequestHandler<CreateOrderItemCommandRequest, ResponseDto<CreateOrderItemCommandResponse>>
    {
        public CreateOrderItemCommandHandler(IMapping mapping, IUnitOfWork unitOfWork) : base(mapping, unitOfWork)
        {
        }

        public async Task<ResponseDto<CreateOrderItemCommandResponse>> Handle(CreateOrderItemCommandRequest request, CancellationToken cancellationToken)
        {
            var data = _mapping.Map<OrderItem>(request);
            unitOfWork.OpenTransactionAsync();
            var createData = unitOfWork.GetWriteRepository<OrderItem>().AddAsync(data);

            await unitOfWork.SaveAsync();
            await unitOfWork.CommitAsync();
            return new ResponseDto<CreateOrderItemCommandResponse>().Success();
        }
    }
}
