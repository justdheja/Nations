using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections;
using System.Collections.Generic;

namespace ConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> result = new List<string>();
            var client = new RestClient("https://restcountries.eu/rest/v2/name/brazil?fullText=true");
            var request = new RestRequest(Method.GET);
            IRestResponse response = client.Execute(request);
            JsonArray array = (JsonArray)SimpleJson.DeserializeObject(response.Content);
            JsonObject obj = (JsonObject)array[0];
            result.Add(obj["capital"].ToString());

            Console.WriteLine(result);
            Console.ReadLine();
        }
    }

    class ListKateglo
    {
        [JsonProperty(PropertyName = "kateglo")]
        public IList Kateglo { get; set; }
    }

    class Definition
    {
        [JsonProperty(PropertyName = "definition")]
        public string ArtiKata { get; set; }
    }
}
