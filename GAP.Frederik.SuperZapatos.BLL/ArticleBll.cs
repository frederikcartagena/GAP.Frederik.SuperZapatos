using GAP.Frederik.SuperZapatos.Common.Util;
using GAP.Frederik.SuperZapatos.Common.Util.ErrorHandling;
using GAP.Frederik.SuperZapatos.Model;
using GAP.Frederik.SuperZapatos.Model.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace GAP.Frederik.SuperZapatos.BLL
{
    public class ArticleBll : IArticleBll
    {
        public List<ArticleModel> GetArticles(ISystemResponse error)
        {
            List<ArticleModel> articles = new List<ArticleModel>();

            try
            {
                string request = WebAPIClient.GetRequest("Articles", "Get", new Dictionary<string, string>(), error);

                if (!string.IsNullOrEmpty(request) && !error.Error)
                {
                    JavaScriptSerializer serializer = new JavaScriptSerializer();
                    ArticlesResponseModel response = serializer.Deserialize<ArticlesResponseModel>(request);

                    if (response != null && !error.Error && response.articles != null)
                        articles = response.articles;
                }
            }
            catch (Exception ex)
            {
                error.Error = true;
                error.Message = "No se pudieron obtener los articulos";
                error.Exception = ex;
            }

            return articles;
        }
    }
}
