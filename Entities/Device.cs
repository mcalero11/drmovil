namespace Entities
{
    public class Device : IEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }

        public int StoreId { get; set; }
    }
}
