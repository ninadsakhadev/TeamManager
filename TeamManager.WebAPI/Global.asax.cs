using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters;
using Newtonsoft.Json;
using System.Net.Http.Formatting;

namespace TeamManager.WebAPI
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            UnityConfig.RegisterComponents(); 
            GlobalConfiguration.Configure(WebApiConfig.Register);
            AutoMapperConfig.Map();
            //var json = GlobalConfiguration.Configuration.Formatters.JsonFormatter;

            //var xml = GlobalConfiguration.Configuration.Formatters.XmlFormatter;
            //var dcs = new System.Runtime.Serialization.DataContractSerializer(typeof(Department), null, int.MaxValue,
            //    false, /* preserveObjectReferences: */ true, null);
            //xml.SetSerializer<Department>(dcs);
            var json = new JsonMediaTypeFormatter();
            //var json = GlobalConfiguration.Configuration.Formatters.JsonFormatter;
            json.SerializerSettings.PreserveReferencesHandling =
                Newtonsoft.Json.PreserveReferencesHandling.None;
            json.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
            GlobalConfiguration.Configuration.Formatters.Clear();
            GlobalConfiguration.Configuration.Formatters.Add(json);
        }
    }
}
