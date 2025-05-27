//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Net.Http;
//using System.Text;
//using System.Threading.Tasks;
//using Newtonsoft.Json;


//namespace _26_05_http
//{
//    internal class http_task
//    {
//        static readonly HttpClient Client = new HttpClient();

//        public static async Task FetchData()
//        {
//            HttpResponseMessage response = await Client.GetAsync("https://api-kodkod.onrender.com/api");
//            response.EnsureSuccessStatusCode();
//            string json = await response.Content.ReadAsStringAsync();

//        }
        

//    }
//}
