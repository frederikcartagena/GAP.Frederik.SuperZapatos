using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace GAP.Frederik.SuperZapatos.Common.Util
{
    public static class WebKeys
    {
        public static class System
        {
            public struct WebAPI
            {
                public static string Url
                {
                    get{
                        return ConfigurationManager.AppSettings["WebAPIUrl"];
                    }
                }
            }
        }
    }
}
