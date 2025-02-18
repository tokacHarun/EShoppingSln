using Application.Bases;
using Application.Features.OrderItems.Commands.CreateOrderItems;
using Application.Features.OrderItems.Commands.UpdateOrderItems;
using Application.Features.OrderItems.Queries.GetAllOrderItems;
using Application.Features.OrderItems.Queries.GetByIdOrderItems;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EShoppingSlnAPI.Controllers.OrderItemsApi
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class OrderItemController : ControllerBase
    {
        private readonly IMediator _mediator;

        public OrderItemController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpPost]
        public async Task<ResponseDto<CreateOrderItemCommandResponse>> CreateAsync(CreateOrderItemCommandRequest request, CancellationToken cancellationToken)
        {
            return await _mediator.Send(request, cancellationToken);
        }
        [HttpPost]
        public Task<ResponseDto<UpdateOrderItemCommandResponse>> UpdateAsync(UpdateOrderItemCommandRequest request, CancellationToken cancellationToken)
        {
            return _mediator.Send(request, cancellationToken);
        }
        [HttpGet]
        public Task<ResponseDto<IList<GetAllOrderItemQueryResponse>>> GetAllAsync(GetAllOrderItemQueryRequest request, CancellationToken cancellationToken)
        {
            return _mediator.Send(request, cancellationToken);
        }
        [HttpGet("{id}")]
        public Task<ResponseDto<GetByIdOrderItemQueryResponse>> GetByIdAsync(GetByIdOrderItemQueryRequest request, CancellationToken cancellationToken)
        {
            return _mediator.Send(request, cancellationToken);
        }
    }
}
