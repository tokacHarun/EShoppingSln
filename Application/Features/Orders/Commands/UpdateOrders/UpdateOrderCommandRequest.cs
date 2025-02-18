using Application.Bases;
using MediatR;

namespace Application.Features.Orders.Commands.UpdateOrders
{
    public class UpdateOrderCommandRequest:IRequest<ResponseDto<UpdateOrderCommandResponse>>
    {
        public UpdateOrderCommandRequest(string name)
        {
            Name = name;
        }

        public string Name { get; }
    }
}
