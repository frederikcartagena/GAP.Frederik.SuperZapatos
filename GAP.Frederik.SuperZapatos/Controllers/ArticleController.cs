using GAP.Frederik.SuperZapatos.BLL;
using GAP.Frederik.SuperZapatos.Common.Util.ErrorHandling;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GAP.Frederik.SuperZapatos.Controllers
{
    public class ArticleController : Controller
    {
        private IArticleBll _articleBll;

        public ArticleController(IArticleBll articleBll)
        {
            this._articleBll = articleBll;
        }

        // GET: Article
        public ActionResult Index()
        {
            ISystemResponse error = new SystemResponse();
            var stores = _articleBll.GetArticles(error);

            return View(stores);
        }
    }
}