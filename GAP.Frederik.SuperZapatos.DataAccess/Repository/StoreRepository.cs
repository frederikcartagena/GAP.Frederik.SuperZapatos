using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GAP.Frederik.SuperZapatos.DataAccess.Context;
using GAP.Frederik.SuperZapatos.Model;

namespace GAP.Frederik.SuperZapatos.DataAccess.Repository
{
    public class StoreRepository : RepositoryBase<SuperZapatosContext>, IStoreRepository
    {
        public List<Store> GetStores()
        {
            using (DataContext)
            {
                return DataContext.Stores.ToList();
            }
        }
    }
}
