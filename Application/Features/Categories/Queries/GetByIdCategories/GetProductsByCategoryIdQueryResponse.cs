namespace Application.Features.Categories.Queries.GetByIdCategories
{
    public class GetProductsByCategoryIdQueryResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Stock { get; set; }
        public decimal Price { get; set; }
        public decimal ReducedPrice { get; set; }
        public string Description { get; set; }
    }
}
