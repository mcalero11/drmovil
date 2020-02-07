using drmovil.forms.Data.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace drmovil.forms.Data.Repository
{
    public class StoreRepository : BaseRepository<Store>
    {
        public StoreRepository(SQLiteAsyncConnection sqliteConnection) : base(sqliteConnection)
        {
        }

        public override Task<bool> AddAsync(Store entity)
        {
            throw new NotImplementedException();
        }

        public override Task<bool> DeleteAsync(Store entity)
        {
            throw new NotImplementedException();
        }

        public override Task<Store> FindByIdAsync(int Id)
        {
            throw new NotImplementedException();
        }

        public override Task<bool> UpdateAsync(Store entity)
        {
            throw new NotImplementedException();
        }
    }
}
