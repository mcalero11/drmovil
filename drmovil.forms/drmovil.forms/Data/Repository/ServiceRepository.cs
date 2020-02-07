using drmovil.forms.Data.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace drmovil.forms.Data.Repository
{
    public class ServiceRepository : BaseRepository<Service>
    {
        public ServiceRepository(SQLiteAsyncConnection sqliteConnection) : base(sqliteConnection)
        {
        }

        public override Task<bool> AddAsync(Service entity)
        {
            throw new NotImplementedException();
        }

        public override Task<bool> DeleteAsync(Service entity)
        {
            throw new NotImplementedException();
        }

        public override Task<Service> FindByIdAsync(int Id)
        {
            throw new NotImplementedException();
        }

        public override Task<bool> UpdateAsync(Service entity)
        {
            throw new NotImplementedException();
        }
    }
}
