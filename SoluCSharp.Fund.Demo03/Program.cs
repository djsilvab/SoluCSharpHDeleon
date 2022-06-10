using SoluCSharp.Fund.Demo02.Models;
using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace SoluCSharp.Fund.Demo03
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            SendRequest<Post> sendRequest = new SendRequest<Post>();
            var post = new Post
            {
                UserId = 741,
                Title = "Productos de Carabayllo",
                Body = "Los mejores productos de maiz"
            };
            var postResult = await sendRequest.Send(post);
            
            //await metPost();

            Console.ReadLine();
        }

        static async Task metPost()
        {
            var urlSrv = "https://jsonplaceholder.typicode.com/posts";
            var client = new HttpClient();

            var post = new Post()
            {
                UserId = 999,
                Body = "prueba de body de david salvador",
                Title = "title de david salvador"
            };

            var jsonPost = JsonSerializer.Serialize<Post>(post, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
            HttpContent content = new StringContent(jsonPost, System.Text.Encoding.UTF8, "application/json");

            var response = await client.PostAsync(urlSrv, content);

            if (response.IsSuccessStatusCode)
            {
                var result = await response.Content.ReadAsStringAsync();

                var postResult = JsonSerializer.Deserialize<Post>(result, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

                Console.WriteLine($"Title: { postResult.Title }, Id: { postResult.Id }");
            }
        }

        static async Task metPut()
        {
            var urlSrv = "https://jsonplaceholder.typicode.com/posts/99";
            var client = new HttpClient();

            var post = new Post
            {
                UserId = 417,
                Body = "Prueba de body de david silva",
                Title = "title de saludo de lima"
            };

            var jsonPost = JsonSerializer.Serialize<Post>(post);
            HttpContent content = new StringContent(jsonPost, System.Text.Encoding.UTF8, "application/json");

            var response = await client.PutAsync(urlSrv, content);

            if (response.IsSuccessStatusCode)
            {
                var result = await response.Content.ReadAsStringAsync();
                var postResult = JsonSerializer.Deserialize<Post>(result, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

                Console.WriteLine($"Title: { postResult.Title }, Id: { postResult.Id }");
            }
        }

        static async Task metDelete()
        {
            var urlSrv = "https://jsonplaceholder.typicode.com/posts/99";
            var client = new HttpClient();

            var response = await client.DeleteAsync(urlSrv);

            if (response.IsSuccessStatusCode)
            {
                var result = await response.Content.ReadAsStringAsync();
                Console.WriteLine("Eliminado");
            }
        }

    }
}
