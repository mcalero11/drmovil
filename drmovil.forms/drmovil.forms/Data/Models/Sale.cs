using SQLite;
namespace drmovil.forms.Data.Models
{
    public class Sale : Entities.Sale
    {
        [PrimaryKey, AutoIncrement]
        public new int Id { get; set; }

    }
}
