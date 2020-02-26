namespace drmovil.api.Models
{
    public class SaleDetail : Entities.SaleDetail
    {
        public Product Product { get; set; }
        public Sale Sale { get; set; }
    }
}
