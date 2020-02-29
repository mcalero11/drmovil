using drmovil.forms.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace drmovil.forms.Data.Repository
{
    public class StoreRepository<T> : Repository<T> where T : Store, new()
    {

        public IList<Store> GetMyStores()
        {
            var list1 = connection.Table<Store>().Where(e => e.UserId == 1).ToList();

            var list2 = connection.Query<Store>(@"
                select s.* from Store s
                inner join Role r on s.Id = r.StoreId
                where r.UserId = ?",
                1).ToList();

            return list1.Concat(list2).ToList();
        }
    }
}
