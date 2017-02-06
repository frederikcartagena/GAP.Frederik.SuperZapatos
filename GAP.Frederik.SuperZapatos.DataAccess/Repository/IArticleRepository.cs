using GAP.Frederik.SuperZapatos.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAP.Frederik.SuperZapatos.DataAccess.Repository
{
    public interface IArticleRepository
    {
        List<Article> GetArticles();

        List<Article> GetArticlesByStoreId(int storeId);
    }
}
