using GAP.Frederik.SuperZapatos.DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using GAP.Frederik.SuperZapatos.Model;
using GAP.Frederik.SuperZapatos.Model.Factory;
using GAP.Frederik.SuperZapatos.WebAPI.Filters;

namespace GAP.Frederik.SuperZapatos.WebAPI.Controllers
{
    [ZapatosAPIAuthorize]
    [RoutePrefix("services/stores")]
    public class StoresController : ApiController
    {
        IStoreRepository _repository;
        ModelFactory _modelFactory;

        public StoresController(IStoreRepository repository)
        {
            _repository = repository;
            _modelFactory = new ModelFactory();
        }

        [Route("")]
        public IHttpActionResult Get()
        {
            var stores = _repository.GetStores();
            var response = _modelFactory.Create(stores);

            return Ok(response);
        }

        public IHttpActionResult Post(Store store)
        {

        }
    }
}