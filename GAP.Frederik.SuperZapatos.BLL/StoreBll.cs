using GAP.Frederik.SuperZapatos.Common.Util;
using GAP.Frederik.SuperZapatos.Common.Util.ErrorHandling;
using GAP.Frederik.SuperZapatos.Model.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace GAP.Frederik.SuperZapatos.BLL
{
    public class StoreBll : IStoreBll
    {
        public List<StoreModel> GetStores(ISystemResponse error)
        {
            List<StoreModel> stores = new List<StoreModel>();

            try
            {
                string request = WebAPIClient.GetRequest("Stores", "Get", new Dictionary<string, string>(), error);

                if (!string.IsNullOrEmpty(request) && !error.Error)
                {
                    JavaScriptSerializer serializer = new JavaScriptSerializer();
                    StoresResponseModel response = serializer.Deserialize<StoresResponseModel>(request);

                    if (response != null && !error.Error && response.stores != null)
                        stores = response.stores;
                }
            }
            catch (Exception ex)
            {
                error.Error = true;
                error.Message = "No se pudieron obtener las tiendas";
                error.Exception = ex;                
            }

            return stores;
        }
    }
}
