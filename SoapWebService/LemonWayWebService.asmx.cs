using Newtonsoft.Json;
using System.Numerics;
using System.Web.Script.Services;
using System.Web.Services;
using System.Xml;

namespace SoapWebService
{
    /// <summary>
    /// Summary description for LemonWayWebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class LemonWayWebService : WebService
    {
        private static readonly log4net.ILog log = 
            log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        [WebMethod]
        public string Fibonacci(int n)
        {
            log.Info(n.ToString());
            if (n > 100 || n<0)
            {
                return "-1";
            }
            else if (n == 0)
            {
                return "0";
            }
            else
            {
                BigInteger penultimate = 0;
                BigInteger ultimate = 1;
                BigInteger Current = 1;
                int i = 2;
                while (i <= n)
                {
                    Current = penultimate + ultimate;
                    penultimate = ultimate;
                    ultimate = Current;
                    i++;
                }
                log.Info(Current.ToString());
                return Current.ToString();
            }
        }

        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        [WebMethod]
        public string FibonacciJSON(int n)
        {
            log.Info(n.ToString());
            if (n > 100 || n < 0)
            {
                return "-1";
            }
            else if (n == 0)
            {
                return "0";
            }
            else
            {
                BigInteger penultimate = 0;
                BigInteger ultimate = 1;
                BigInteger Current = 1;
                int i = 2;
                while (i <= n)
                {
                    Current = penultimate + ultimate;
                    penultimate = ultimate;
                    ultimate = Current;
                    i++;
                }
                log.Info(Current.ToString());
                return Current.ToString();
            }
        }



        public string XmlToJson(string xml)
        {
            try
            {
                XmlDocument doc = new XmlDocument();
                doc.LoadXml(xml);
                return JsonConvert.SerializeXmlNode(doc);
            }
            catch (XmlException ex)
            {
                return "bad xml format";
                throw ex;
            }
        }

    }
}
