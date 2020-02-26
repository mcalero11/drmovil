namespace drmovil.api.Models
{
    public class Role : Entities.Role
    {
        public User User { get; set; }

        public Store Store { get; set; }
    }
}
