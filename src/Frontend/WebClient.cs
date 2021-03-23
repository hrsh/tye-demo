using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Frontend
{
    public class WebClient
    {
        private readonly JsonSerializerOptions options = new JsonSerializerOptions()
        {
            PropertyNameCaseInsensitive = true,
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
        };

        private readonly HttpClient _client;

        public WebClient(HttpClient client)
        {
            _client = client;
        }

        public async Task<string> GetMessageAsync()
        {
            var responseMessage = await _client.GetAsync("/message/index");
            var content = await responseMessage.Content.ReadAsStringAsync();
            return content;
        }
    }
}
