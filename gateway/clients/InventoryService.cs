using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;
using gateway.clients.Interfaces;
using Newtonsoft.Json;

namespace gateway.clients
{
    public class InventoryService : IInventoryService
    {
        private readonly HttpClient httpClient;

        public InventoryService(HttpClient httpClient)
        {
            this.httpClient = httpClient ?? throw new ArgumentNullException(nameof(httpClient));
        }

        public async Task<string[]> GetValues()
        {
            var result = await this.httpClient.GetStringAsync("values");
            var parsed = JsonConvert.DeserializeObject<string[]>(result);
            return parsed;
        }
    }
}