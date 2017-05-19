using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;

namespace crick_bot1
{
    public enum HttpVerb
    {
        GET,
        POST,
        PUT,
        DELETE
    }

    public class httpReqRes
    {
        public string EndPoint { get; set; }
        public HttpVerb Method { get; set; }
        public string ContentType { get; set; }
        public string PostData { get; set; }

        public httpReqRes()
        {
            EndPoint = "http://cricapi.com/api/fantasySummary/?apikey=tKfayP2z2jaYFXCZXC6sYNEKrC13&unique_id=1034809";
            Method = HttpVerb.GET;
            PostData = "";
        }


        public String MakeRequest()
        {
            String res_str = "";
            int x = 1;
            //RootObject ro;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(EndPoint);
            request.Method = Method.ToString();
            using (HttpWebResponse res = (HttpWebResponse)request.GetResponse())
            {
                /*if(res.StatusCode == HttpStatusCode.OK)
                {
                    return res.StatusCode.ToString();
                }*/
                using (System.IO.Stream res_stream = res.GetResponseStream())
                {
                    if (res_stream != null)
                    {
                        StreamReader read = new StreamReader(res_stream);
                        res_str = read.ReadToEnd();

                        /*RootObject ro = JsonConvert.DeserializeObject<RootObject>(res_str);
                        x = ro.ttl;*/
                    }
                }
            }
            return res_str;
        }

    }
}