using Application.Bases;
using MediatR;

namespace Application.Features.OrderItems.Commands.UpdateOrderItems
{
    public class UpdateOrderItemCommandRequest : IRequest<ResponseDto<UpdateOrderItemCommandResponse>>
    {
        public UpdateOrderItemCommandRequest(string name)
        {
            Name = name;
        }

        public string Name { get; }
    }
}
