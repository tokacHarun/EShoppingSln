using Application.Bases;
using Application.Interfaces.AutoMappers;
using Application.Interfaces.UnitOfWorks;
using Domain.Entities;
using MediatR;

namespace Application.Features.Categories.Commands.CreateCategory
{
    public class CreateCommandCategoryHandler : BaseHandler, IRequestHandler<CreateCommandCategoryRequest, ResponseDto<CreateCommandCategoryResponse>>
    {
        public CreateCommandCategoryHandler(IMapping mapping, IUnitOfWork unitOfWork) : base(mapping, unitOfWork)
        {
        }

        public async Task<ResponseDto<CreateCommandCategoryResponse>> Handle(CreateCommandCategoryRequest request, CancellationToken cancellationToken)
        {
            var mapData = _mapping.Map<Category, CreateCommandCategoryRequest>(request);
            unitOfWork.OpenTransactionAsync();
            var createData = await unitOfWork.GetWriteRepository<Category>().AddAsync(mapData);
            await unitOfWork.SaveAsync();
            await unitOfWork.CommitAsync();
            return new ResponseDto<CreateCommandCategoryResponse>().Success();
        }
    }
}
