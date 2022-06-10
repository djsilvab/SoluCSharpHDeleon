using System;
using System.Threading;
using System.Threading.Tasks;
using System.Net.Http;
using SoluCSharp.Fund.Demo02.Models;
using System.Text.Json;
using System.Collections.Generic;

namespace SoluCSharp.Fund.Demo02
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Peticiones HTTP!");

            var urlSrv = "https://jsonplaceholder.typicode.com/posts";
            HttpClient client = new HttpClient();

            var result = await client.GetAsync(urlSrv);

            if (result.IsSuccessStatusCode)
            {
                var content = await result.Content.ReadAsStringAsync();
                var posts = JsonSerializer.Deserialize<List<Post>>(content, 
                    new JsonSerializerOptions { 
                        PropertyNameCaseInsensitive = true
                    });

                Console.WriteLine(posts.Count);
            }
           
            Console.ReadLine();
        }
    }
}
