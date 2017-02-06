using GAP.Frederik.SuperZapatos.Model.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAP.Frederik.SuperZapatos.Model.Factory
{
    public class ModelFactory
    {
        public ArticlesResponseModel Create(List<Article> articles)
        {
            ArticlesResponseModel model = new ArticlesResponseModel();

            model.total_elements = articles.Count();
            model.articles = articles.Select(a => Create(a)).ToList();                      

            return model;
        }

        public ArticleModel Create(Article article)
        {
            return new ArticleModel()
            {
                description = article.description,
                id = article.id,
                name = article.name,
                price = article.price,
                store_id = article.store_id,
                total_in_shelf = article.total_in_shelf,
                total_in_vault = article.total_in_vault
            };
        }
    }
}
