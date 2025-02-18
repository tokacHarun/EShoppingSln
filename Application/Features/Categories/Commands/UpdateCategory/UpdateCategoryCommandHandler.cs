using Application.Bases;
using Application.Interfaces.AutoMappers;
using Application.Interfaces.UnitOfWorks;
using Domain.Entities;
using MediatR;

namespace Application.Features.Categories.Commands.UpdateCategory
{
    public class UpdateCategoryCommandHandler : BaseHandler, IRequestHandler<UpdateCategoryCommandRequest, ResponseDto<UpdateCategoryCommandResponse>>
    {
        public UpdateCategoryCommandHandler(IMapping mapping, IUnitOfWork unitOfWork) : base(mapping, unitOfWork)
        {
        }

        public async Task<ResponseDto<UpdateCategoryCommandResponse>> Handle(UpdateCategoryCommandRequest request, CancellationToken cancellationToken)
        {
            var mapData = _mapping.Map<Category, UpdateCategoryCommandRequest>(request);
            unitOfWork.OpenTransactionAsync();
            var updateData = unitOfWork.GetWriteRepository<Category>().UpdateAsync(mapData);
            await unitOfWork.SaveAsync();
            await unitOfWork.CommitAsync();
            return new ResponseDto<UpdateCategoryCommandResponse>().Success();
        }
    }
}
