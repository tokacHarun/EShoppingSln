using Application.Bases;
using MediatR;

namespace Application.Features.OrderItems.Commands.CreateOrderItems
{
    public class CreateOrderItemCommandRequest : IRequest<ResponseDto<CreateOrderItemCommandResponse>>
    {
        public CreateOrderItemCommandRequest(string name)
        {
            Name = name;
        }

        public string Name { get; }
    }
}
