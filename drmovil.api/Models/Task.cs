namespace drmovil.api.Models
{
    public class Task : Entities.Task
    {
        public Store Store { get; set; }
        public int StoreId { get; set; }
    }
}
