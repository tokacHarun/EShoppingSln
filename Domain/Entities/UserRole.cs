using Domain.Comman;

namespace Domain.Entities
{
    public class UserRole : BaseEntity
    {
        public UserRole(string name, int id)
        {
            this.Id = id;
            this.Name = name;
        }
        public UserRole()
        {

        }
        public string Name { get; set; }
        public IList<User> Users { get; set; }
    }
}
