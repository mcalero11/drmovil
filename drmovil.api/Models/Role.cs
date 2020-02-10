namespace drmovil.api.Models
{
    public class Role : Entities.Role
    {
        public User User { get; set; }
        public int UserId { get; set; }

        public Store Store { get; set; }
        public int StoreId { get; set; }
    }
}
