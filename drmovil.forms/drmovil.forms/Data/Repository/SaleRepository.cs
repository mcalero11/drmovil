using drmovil.forms.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace drmovil.forms.Data.Repository
{
    class SaleRepository<T> : Repository<T> where T : Sale, new()
    {
        public IList<Sale> GetSalesByStore(Store store)
        {
            var lst = connection.Table<Sale>().Where(x => x.StoreId == store.Id).ToList();

            return lst;
        }
    }
}
