using Domain.Enums;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Configuration;

namespace Application.APIRequest
{
    public class GenerateCryptoAPI
    {
        
        #region Request Generator
        private HttpWebRequest GetRequest(CoinType coin, byte[] postData,string fullAddress)
        {
            string APIKey = WebConfigurationManager.AppSettings["APIKey"];
            var request = (HttpWebRequest)WebRequest.Create(fullAddress);
            var data = postData;
            request.Method = "POST";
            request.Headers.Add("X-API-Key", APIKey);
            request.ContentType = "application/json";
            request.ContentLength = data.Length;
            return request;
        }
        public string SendRequest(CoinType coin,string fullAddress)
        {
            string data = String.Empty;
            byte[] postData = Encoding.ASCII.GetBytes(data);
            HttpWebRequest request = GetRequest(coin, postData, fullAddress);
            using (var stream = request.GetRequestStream())
            {
                stream.Write(postData, 0, postData.Length);
            }
            var response = (HttpWebResponse)request.GetResponse();
            var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();
            return responseString;
        }
        #endregion

        

    }
}
