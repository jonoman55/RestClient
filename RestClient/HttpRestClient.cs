using System;
using System.IO;
using System.Net;
using Newtonsoft.Json.Linq;

namespace RestClient
{
    public enum HttpVerb
    {
        GET,
        POST,
        PUT,
        DELETE
    }

    public class HttpRestClient
    {
        public string  EndPoint { get; set; }
        public HttpVerb HttpMethod { get; set; }

        public HttpRestClient()
        {
            EndPoint = string.Empty;
            HttpMethod = HttpVerb.GET;
        }

        public string MakeRequest()
        {
            string strRespVal = string.Empty;

            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(EndPoint);
            req.Method = HttpMethod.ToString();
            using (HttpWebResponse resp = (HttpWebResponse)req.GetResponse())
            {
                if (resp.StatusCode != HttpStatusCode.OK)
                {
                    throw new ApplicationException($"error code: {resp.StatusCode.ToString()}");
                }

                using (Stream respStream = resp.GetResponseStream())
                {
                    if (respStream != null)
                    {
                        using (StreamReader reader = new StreamReader(respStream))
                        {
                            strRespVal = reader.ReadToEnd();
                        }
                    }        
                }
            }

            return strRespVal;
        }
    }

    public static class JsonExt
    {
        public static string FormatJson(this string json)
        {
            return JToken.Parse(json).ToString();
        }
    }
}
