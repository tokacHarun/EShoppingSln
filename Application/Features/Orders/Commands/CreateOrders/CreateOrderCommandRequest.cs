using Application.Bases;
using MediatR;

namespace Application.Features.Orders.Commands.CreateOrders
{
    public class CreateOrderCommandRequest : IRequest<ResponseDto<CreateOrderCommandResponse>>
    {
        public CreateOrderCommandRequest(string name)
        {
            Name = name;
        }

        public string Name { get; }
    }
}
