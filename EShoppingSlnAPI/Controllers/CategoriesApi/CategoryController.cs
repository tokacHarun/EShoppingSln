using Application.Bases;
using Application.Features.Categories.Commands.CreateCategory;
using Application.Features.Categories.Commands.UpdateCategory;
using Application.Features.Categories.Queries.GetAllCategory;
using Application.Features.Categories.Queries.GetByIdCategory;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace EShoppingSlnAPI.Controllers.CategoriesApi
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CategoryController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpPost]
        public async Task<ResponseDto<CreateCommandCategoryResponse>> CreateAsync(CreateCommandCategoryRequest request, CancellationToken cancellationToken)
        {
            return await _mediator.Send(request, cancellationToken);
        }
        [HttpPost]
        public async Task<ResponseDto<UpdateCategoryCommandResponse>> UpdateAsync(UpdateCategoryCommandRequest request, CancellationToken cancellationToken)
        {
            return await _mediator.Send(request, cancellationToken);
        }
        [HttpGet]
        public async Task<ResponseDto<IList<GetAllQueryCategoryResponse>>> GetAllAsync(GetAllQueryCategoryRequest request, CancellationToken cancellationToken)
        {
            return await _mediator.Send(request, cancellationToken);
        }

        [HttpGet("{id}")]
        public async Task<ResponseDto<GetByIdQueryCategoryResponse>> GetByIdAsync(int id)
        {
            return await _mediator.Send(new GetByIdQueryCategoryRequest(id));
        }
      
    }
}
