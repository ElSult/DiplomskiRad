using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
namespace auto_skola_PCL.Util
{
   public class WebAPIHelper
    {
        public HttpClient client { get; set; }
        public string route { get; set; }

        public WebAPIHelper(string uri, string route)
        {
            client = new HttpClient();
            client.BaseAddress = new Uri(uri);
            this.route = route;

        }
        public HttpResponseMessage GetResponse(string parametar = "")
        {
            return client.GetAsync(route + "/" + parametar).Result;
        }
        public HttpResponseMessage GetResponsee(int parametar)
        {
            return client.GetAsync(route + "/" + parametar).Result;
        }
        //api/Korisnici/{username}
        public HttpResponseMessage GetActionResponse(string action, string parametar = "")
        {
            return client.GetAsync(route + "/" + action + "/" + parametar).Result;
        }
        //api/Korisnici/action
        public HttpResponseMessage GetResponseAction(string action)
        {
            return client.GetAsync(route + "/" + action).Result;
        }

        public HttpResponseMessage GetActionResponse(string action, int parametar)
        {
            return client.GetAsync(route + "/" + action + "/" + parametar).Result;
        }

        public HttpResponseMessage PostActionResponse(string action, Object obj)
        {
            var jsonObject = new StringContent(JsonConvert.SerializeObject(obj), Encoding.UTF8, "application/json");
            return client.PostAsync(route +"/"+action+"/"+1, jsonObject).Result;
        }

        public HttpResponseMessage PostResponse(object obj)
        {
            var jsonObject = new StringContent(JsonConvert.SerializeObject(obj), Encoding.UTF8, "application/json");
            return client.PostAsync(route, jsonObject).Result;
            // return client.PostAsJsonAsync(route, obj).Result;
        }

        //public HttpResponseMessage PostResponse(Object newObject)
        //{
        //    var jsonObject = new StringContent(JsonConvert.SerializeObject(newObject),
        //        Encoding.UTF8, "application/json");
        //    return client.PostAsync(route, jsonObject).Result;
        //}

        public HttpResponseMessage PutResponse(int id, object existingObject)
        {
            var jsonObject = new StringContent(JsonConvert.SerializeObject(existingObject), Encoding.UTF8, "application/json");
            return client.PutAsync(route + "/" + id, jsonObject).Result;
        }
    }
}
