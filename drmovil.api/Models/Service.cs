namespace drmovil.api.Models
{
    public class Service : Entities.Service
    {
        public Store Store { get; set; }
        public int StoreId { get; set; }
        public User User { get; set; }
        public int UserId { get; set; } // Created by
    }
}
