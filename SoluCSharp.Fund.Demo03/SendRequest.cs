using SoluCSharp.Fund.Demo02.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace SoluCSharp.Fund.Demo03
{
    public class SendRequest<T> where T : ISend
    {
        private HttpClient _cliente = new HttpClient();

        public async Task<T> Send(T model)
        {
            var urlSrv = "https://jsonplaceholder.typicode.com/posts";
            var jsonData  = JsonSerializer.Serialize<T>(model);
            HttpContent content = new StringContent(jsonData, System.Text.Encoding.UTF8, "application/json");            
            var response = await _cliente.PostAsync(urlSrv, content);
            if (response.IsSuccessStatusCode)
            {
                var result = await response.Content.ReadAsStringAsync();
                var modelResult = JsonSerializer.Deserialize<T>(result, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
                return modelResult;
            }

            return default(T);
        }
    }
}
