using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Webservices.Models;

namespace Webservices
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);


            //GlobalConfiguration.Configuration.Formatters.JsonFormatter.SerializerSettings.ReferenceLoopHandling =
            //    Newtonsoft.Json.ReferenceLoopHandling.Serialize;
            //GlobalConfiguration.Configuration.Formatters.Remove
            //    (GlobalConfiguration.Configuration.Formatters.XmlFormatter);

  //          var serializerSettings =
  //GlobalConfiguration.Configuration.Formatters.JsonFormatter.SerializerSettings;
  //          var contractResolver =
  //            (DefaultContractResolver)serializerSettings.ContractResolver;
  //          contractResolver.IgnoreSerializableAttribute = true;
        }
    }
}
