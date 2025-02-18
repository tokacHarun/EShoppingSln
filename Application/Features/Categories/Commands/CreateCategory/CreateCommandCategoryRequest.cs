using Application.Bases;
using MediatR;

namespace Application.Features.Categories.Commands.CreateCategory
{
    public class CreateCommandCategoryRequest : IRequest<ResponseDto<CreateCommandCategoryResponse>>
    {
        public string Name { get; set; }

        public CreateCommandCategoryRequest(string name)
        {
            this.Name = name;
        }
    }
    
}
