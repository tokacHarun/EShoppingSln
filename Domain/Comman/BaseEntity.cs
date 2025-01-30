namespace Domain.Comman
{
    public class BaseEntity : IBaseEntity
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime ModifyDate { get; set; } = DateTime.Now;
        public bool IsDeleted { get; set; } = false;
        public bool IsActive { get; set; } = true;
    }
}
