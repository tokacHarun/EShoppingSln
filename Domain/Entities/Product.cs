using Domain.Comman;

namespace Domain.Entities
{
    public class Product : BaseEntity
    {
        public Product()
        {

        }
        public Product(int id, string name, int categoryId, decimal price, decimal reducedPrice, string description)
        {
            this.Id = id;
            this.Name = name;
            this.CategoryId = categoryId;
            this.Price = price;
            this.ReducedPrice = reducedPrice;
            this.Description = description;
        }
        public string Name { get; set; }
        public int Stock { get; set; }
        public decimal Price { get; set; }
        public decimal ReducedPrice { get; set; }
        public string Description { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
