using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LeFrenchMelee.Web.Helpers
{
    public class RestHelper
    {
        public static IRestResponse ExecuteRestRequest(string uri, Method method, string content, params KeyValuePair<string, object>[] uriParams)
        {
            RestClient client = new RestClient("http://localhost/LeFrenchMelee.Web/api/");

            RestRequest request = new RestRequest(uri, method)
            {
                RequestFormat = DataFormat.Json,
            };

            foreach (KeyValuePair<string, object> param in uriParams)
            {
                request.AddParameter(param.Key, param.Value, ParameterType.QueryString);
            }

            if (!string.IsNullOrWhiteSpace(content))
            {
                request.AddParameter("application/json", content, ParameterType.RequestBody);
            }

            return client.Execute(request);
        }
    }
}