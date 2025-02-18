using Application.Bases;
using Application.Interfaces.AutoMappers;
using Application.Interfaces.UnitOfWorks;
using Domain.Entities;
using MediatR;

namespace Application.Features.Orders.Commands.CreateOrders
{
    public class CreateOrderCommandHandler : BaseHandler, IRequestHandler<CreateOrderCommandRequest, ResponseDto<CreateOrderCommandResponse>>
    {
        public CreateOrderCommandHandler(IMapping mapping, IUnitOfWork unitOfWork) : base(mapping, unitOfWork)
        {
        }

        public async Task<ResponseDto<CreateOrderCommandResponse>> Handle(CreateOrderCommandRequest request, CancellationToken cancellationToken)
        {
            var mapData = _mapping.Map<Order, CreateOrderCommandRequest>(request);
            unitOfWork.OpenTransactionAsync();
            var createData = unitOfWork.GetWriteRepository<Order>().AddAsync(mapData);
            await unitOfWork.SaveAsync();
            await unitOfWork.CommitAsync();
            return new ResponseDto<CreateOrderCommandResponse>().Success();
        }
    }
}
