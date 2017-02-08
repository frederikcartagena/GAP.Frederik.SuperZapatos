using GAP.Frederik.SuperZapatos.BLL;
using GAP.Frederik.SuperZapatos.Common.Util.ErrorHandling;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GAP.Frederik.SuperZapatos.Controllers
{
    public class StoreController : Controller
    {
        private  IStoreBll _storeBll;

        public StoreController(IStoreBll storeBll)
        {
            this._storeBll = storeBll;
        }

        // GET: Store
        public ActionResult Index()
        {
            ISystemResponse error = new SystemResponse();
            var stores = _storeBll.GetStores(error);

            return View(stores);
        }

        public ActionResult Create()
        {
            return View();
        }
    }
}