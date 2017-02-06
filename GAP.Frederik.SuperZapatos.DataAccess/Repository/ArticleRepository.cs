using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GAP.Frederik.SuperZapatos.DataAccess.Context;
using GAP.Frederik.SuperZapatos.Model;
using System.Data.Entity;

namespace GAP.Frederik.SuperZapatos.DataAccess.Repository
{
    public class ArticleRepository : RepositoryBase<SuperZapatosContext>, IArticleRepository
    {
        public List<Article> GetArticles()
        {
            using (DataContext)
            {
                return DataContext.Articles.ToList();
            }
        }

        public List<Article> GetArticlesByStoreId(int storeId)
        {
            List<Article> articles = new List<Article>();

            try
            {
                using (DataContext)
                {
                    articles = DataContext.Stores
                                .Where(s => s.id == storeId)
                                .Include(s => s.Articles)
                                .FirstOrDefault().Articles.ToList();
                }
            }
            catch (Exception)
            {
                //Log exception
                throw;
            }

            return articles;
        }
    }
}
