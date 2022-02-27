using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Leaf.xNet;
using Newtonsoft.Json.Linq;
using AngleSharp.Html;

namespace InstBlocker
{

    class inst
    {
        static HttpRequest request = new HttpRequest();
        static RequestParams Params = new RequestParams();
        public static string getPageAuth()
        {
            request = new HttpRequest();
            string response = request.Get("https://www.instagram.com/accounts/login/?source=auth_switcher").ToString();
            return response;
        }

        public static string[] parsParams()
        {
            string response = getPageAuth();
            return new string[]
            {
                System.Text.RegularExpressions.Regex.Match(response, "rollout_hash\":\"(.*?)\"").Groups[1].Value,
                System.Text.RegularExpressions.Regex.Match(response, "csrf_token\":\"(.*?)\"").Groups[1].Value,
            };
        }
        public static string Auth(string Login, string Password)
        {
            string[] Data = parsParams();

            request = new HttpRequest();
            Params = new RequestParams();
            request.UserAgentRandomize();
            request.KeepAlive = true;
            request.Cookies = new CookieStorage(true);
            request.AddHeader(HttpHeader.Origin, "https://www.instagram.com");
            request.AddHeader("X-Instagram-AJAX", Data[0]);
            request.AddHeader(HttpHeader.ContentType, "nosniff");
            request.AddHeader(HttpHeader.Accept, "*/*");
            request.AddHeader("X-Requsted-With", "XMLHttpRequest");
            request.AddHeader("X-CSRFToken", Data[1]);
            request.AddHeader(HttpHeader.Referer, "https://www.instagram.com/accounts/login/?source=auth_switcher");
            request.AddHeader("Accept-Launguage", "ru-RU,ru;q=0.9,en-US;q=0.8,en;q=0.7,af;q=0.6");
            request.AddHeader("Accept-Encoding", "gzip, deflate"); 

            Params["username"] = Login;
            Params["password"] = Password;
            Params["queryParams"] = "{\"source\":\"auth_switcher\"}";
            Params["optIntoOneTap"] = false;
            Params["stopDeletionNonce"] = "";
            Params["trustedDeviceRecords"] = "";
            string response = request.Post("https://www.instagram.com/accounts/login/ajax/", Params).ToString();
            return response;
        }
    }
}
