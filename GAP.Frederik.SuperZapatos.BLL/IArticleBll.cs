using GAP.Frederik.SuperZapatos.Common.Util.ErrorHandling;
using GAP.Frederik.SuperZapatos.Model.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GAP.Frederik.SuperZapatos.BLL
{
    public interface IArticleBll
    {
        List<ArticleModel> GetArticles(ISystemResponse error);
    }
}
