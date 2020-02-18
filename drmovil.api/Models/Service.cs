namespace drmovil.api.Models
{
    public class Service : Entities.Service
    {
        public Store Store { get; set; }
        public int UserId { get; set; } // Created by
    }
}
