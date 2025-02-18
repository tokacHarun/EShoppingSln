using Application.Bases;
using Application.Features.Orders.Commands.CreateOrders;
using Application.Features.Orders.Commands.UpdateOrders;
using Application.Features.Orders.Queries.GetAllOrders;
using Application.Features.Orders.Queries.GetByIdOrders;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EShoppingSlnAPI.Controllers.OrdersApi
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IMediator _mediator;

        public OrderController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpPost]
        public async Task<ResponseDto<CreateOrderCommandResponse>> CreateAsync(CreateOrderCommandRequest request, CancellationToken cancellationToken)
        {
            return await _mediator.Send(request, cancellationToken);
        }
        [HttpPost]
        public async Task<ResponseDto<UpdateOrderCommandResponse>> UpdateAsync(UpdateOrderCommandRequest request, CancellationToken cancellationToken)
        {
            return await _mediator.Send(request, cancellationToken);
        }
        [HttpGet]
        public async Task<ResponseDto<IList<GetAllOrderQueryResponse>>> GetAllAsync(GetAllOrderQueryRequest request, CancellationToken cancellationToken)
        {
            return await _mediator.Send(request, cancellationToken);
        }
        [HttpGet("{id}")]
        public async Task<ResponseDto<GetByIdOrderQueryResponse>> GetByIdAsync(GetByIdOrderQueryRequest request, CancellationToken cancellationToken)
        {
            return await _mediator.Send(request, cancellationToken);
        }
    }
}
