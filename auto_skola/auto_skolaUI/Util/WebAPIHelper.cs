using auto_skolaAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace auto_skolaUI.Util
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

        public async Task<HttpResponseMessage> GetActionResponseAsync(string action, object parametar = null)
        {
            if (parametar != null)
                return await client.GetAsync(route + "/" + action + "/" + parametar.ToString());

            return await client.GetAsync(route + "/" + action);
        }

        public HttpResponseMessage GetResponseA(string action)
        {
            return client.GetAsync(route + "/" + action).Result;
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

        public HttpResponseMessage PostResponse(object obj)
        {
            return client.PostAsJsonAsync(route, obj).Result;
        }
        public HttpResponseMessage PostActionResponse(string action, object obj)
        {
            return client.PostAsJsonAsync(route + "/" + action + "/" + 1, obj).Result;
        }
        public HttpResponseMessage PutResponse(int id, object existingObject)
        {
            return client.PutAsJsonAsync(route + "/" + id, existingObject).Result;
        }
        public HttpResponseMessage DeleteResponse(int id)
        {
            return client.DeleteAsync(route + "/" + id).Result;
        }
    }
}
