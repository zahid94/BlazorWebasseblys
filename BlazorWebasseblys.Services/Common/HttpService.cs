using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BlazorWebasseblys.Services.Common
{
    public class HttpService<TEntity> where TEntity:class
    {
        private readonly HttpClient httpClient;
        public HttpService()
        {
            httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("https://localhost:44307");
        }

        public async Task<IEnumerable<TEntity>> Get(string url)
        {
            return await httpClient.GetFromJsonAsync<IEnumerable<TEntity>>(url);
        }

        public async Task<object> Post(string url,TEntity entity)
        {
            return await httpClient.PostAsJsonAsync<object>(url,entity);
        }

        public async Task<object> Delete(string url)
        {
            return await httpClient.DeleteAsync(url);
        }

        public async Task<object> Put(string url,TEntity entity)
        {
            return await httpClient.PutAsJsonAsync<object>(url, entity);
        }
    }
}
