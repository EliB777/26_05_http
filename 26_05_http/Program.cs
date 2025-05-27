using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;




namespace _26_05_http
{
    internal class Program
    {

        //public static HttpClient client;
        public static async Task SendHttpGET()
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync(" https://api-kodkod.onrender.com/api/data");
            string content = await response.Content.ReadAsStringAsync();
            List<Post> a = JsonConvert.DeserializeObject<List<Post>>(content);
            for (int i = 0; i < a.Count; i++)
            {
                Console.WriteLine($"{i+1}, id:{a[i].id} name: {a[i].name}");
            }
        }





        static async Task Main(string[] args)
        {
            await SendHttpGET();
            //files.ShowManu();
            //files.readFile();
        }
    }
}
