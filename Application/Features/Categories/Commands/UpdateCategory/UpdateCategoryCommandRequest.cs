using Application.Bases;
using MediatR;

namespace Application.Features.Categories.Commands.UpdateCategory
{
    public class UpdateCategoryCommandRequest : IRequest<ResponseDto<UpdateCategoryCommandResponse>>
    {
        public UpdateCategoryCommandRequest(string name)
        {
            Name = name;
        }

        public string Name { get; }
    }
}
