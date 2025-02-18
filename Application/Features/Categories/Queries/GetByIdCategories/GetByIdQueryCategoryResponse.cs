using Application.Features.Categories.Queries.GetByIdCategories;

namespace Application.Features.Categories.Queries.GetByIdCategory
{
    public class GetByIdQueryCategoryResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IList<GetProductsByCategoryIdQueryResponse> GetProducts { get; set; }
    }
}
