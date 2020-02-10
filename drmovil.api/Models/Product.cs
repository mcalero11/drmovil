namespace drmovil.api.Models
{
    public class Product : Entities.Product
    {
        public Store Store { get; set; }
        public int StoreId { get; set; }
    }
}
