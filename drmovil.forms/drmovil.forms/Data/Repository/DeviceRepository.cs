using drmovil.forms.Data.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace drmovil.forms.Data.Repository
{
    public class DeviceRepository : BaseRepository<Device>
    {
        public DeviceRepository(SQLiteAsyncConnection sqliteConnection) : base(sqliteConnection)
        {
        }

        public override Task<bool> AddAsync(Device entity)
        {
            throw new NotImplementedException();
        }

        public override Task<bool> DeleteAsync(Device entity)
        {
            throw new NotImplementedException();
        }

        public override Task<Device> FindByIdAsync(int Id)
        {
            throw new NotImplementedException();
        }

        public override Task<bool> UpdateAsync(Device entity)
        {
            throw new NotImplementedException();
        }
    }
}
