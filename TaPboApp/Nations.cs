using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaPboApp
{
    class Nations
    {
        public static List<string> GetIbuKota(string negara)
        {
            List<string> result = new List<string>();
            var client = new RestClient("https://restcountries.eu/rest/v2/name/" + negara);
            var request = new RestRequest(Method.GET);
            request.AddHeader("fullText", "true");
            IRestResponse response = client.Execute(request);
            try
            {
                JsonArray array = (JsonArray)SimpleJson.DeserializeObject(response.Content);
                JsonObject obj = (JsonObject)array[0];
                result.Add("Capital City :" + " " + obj["capital"].ToString());
                result.Add("Region :" + " " + obj["region"].ToString());
                result.Add("SubRegion :" + " " + obj["subregion"].ToString());
                JsonArray currencyArray = (JsonArray)obj["currencies"];
                JsonObject currency = (JsonObject)currencyArray[0];
                result.Add("Currency Name :" + " " + currency["name"].ToString());
                result.Add("Currency Symbol :" + " " + currency["symbol"].ToString());
            }
            catch
            {
                result.Add("Nation not Found");
            }
            return result;
        }
    }
}
