using Domain.Comman;

namespace Domain.Entities
{
    public class User : BaseEntity
    {
        public User(string name, string surname, int id, string password, DateTime birthday, string email)
        {
            this.Name = name;
            this.Surname = surname;
            this.Id = id;
            this.Password = password;
            this.Email = email;
            this.BirthDay = birthday;
        }
        public User()
        {

        }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime BirthDay { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int UserRoleId { get; set; }
        public UserRole UserRole { get; set; }
        public IList<Address> Addresses { get; set; }
    }
}
