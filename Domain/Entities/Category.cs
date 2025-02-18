using Domain.Comman;

namespace Domain.Entities
{
    public class Category : BaseEntity
    {
        public Category()
        {

        }
        public Category(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }
        public string Name { get; set; }
        public IList<Product> Products { get; set; }
    }
}
