using System.Collections.Generic;
using BurneechWebToolbox.Models;
using System.Threading.Tasks;
using System.Net.Http.Json;
using System.Net.Http;

namespace BurneechWebToolbox.Services
{
    public class JSONDataService : IDataService
    {
        private readonly HttpClient _httpClient;

        public JSONDataService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<ToolboxCategory>> GetToolboxCategories()
        {
            var toolboxCategories = await _httpClient.GetFromJsonAsync<List<ToolboxCategory>>("data/ToolboxData.json");
            return toolboxCategories;
        }
    }
}
