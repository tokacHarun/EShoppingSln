namespace Application.Features.Products.Queries.GetByIdProducts
{
    public class GetByIdProductQueryResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Stock { get; set; }
        public decimal Price { get; set; }
    }
}
