namespace drmovil.api.Models
{
    public class Device : Entities.Device
    {
        public Store Store { get; set; }
        public int StoreId { get; set; }
    }
}
