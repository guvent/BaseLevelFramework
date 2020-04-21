using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Business.Utilities.Common
{
    public class WcfProxy<T>
    {
        // http://localhost:51077/ProductService.svc
        // http://localhost:51077/{0}.svc
        // IProductService.svc > IProductService.svc
        public static T CreateChannel()
        {
            // WebUI -> Web.config ->  <appSettings>  -->  <add key="ServiceAddress" value="http://localhost:51077/{0}.svc" />
            string baseAddress = ConfigurationManager.AppSettings["ServiceAddress"];
            string address = string.Format(baseAddress, typeof(T).Name.Substring(1));

            var binding = new BasicHttpBinding();
            var channel = new ChannelFactory<T>(binding, address);

            return channel.CreateChannel();
        }
    }
}
