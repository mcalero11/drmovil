using drmovil.forms.Data.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace drmovil.forms.Data.Repository
{
    public class ProductRepository : BaseRepository<Product>
    {
        public ProductRepository(SQLiteAsyncConnection sqliteConnection) : base(sqliteConnection)
        {
        }

        public override Task<bool> AddAsync(Product entity)
        {
            throw new NotImplementedException();
        }

        public override Task<bool> DeleteAsync(Product entity)
        {
            throw new NotImplementedException();
        }

        public override Task<Product> FindByIdAsync(int Id)
        {
            throw new NotImplementedException();
        }

        public override Task<bool> UpdateAsync(Product entity)
        {
            throw new NotImplementedException();
        }
    }
}
