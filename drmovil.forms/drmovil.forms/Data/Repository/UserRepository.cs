using drmovil.forms.Data.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace drmovil.forms.Data.Repository
{
    public class UserRepository : BaseRepository<User>
    {
        public UserRepository(SQLiteAsyncConnection sqliteConnection) : base(sqliteConnection)
        {
        }

        public override Task<bool> AddAsync(User entity)
        {
            throw new NotImplementedException();
        }

        public override Task<bool> DeleteAsync(User entity)
        {
            throw new NotImplementedException();
        }

        public override Task<User> FindByIdAsync(int Id)
        {
            throw new NotImplementedException();
        }

        public override Task<bool> UpdateAsync(User entity)
        {
            throw new NotImplementedException();
        }
    }
}
