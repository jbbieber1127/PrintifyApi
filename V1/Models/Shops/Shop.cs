using Newtonsoft.Json;

namespace PrintifyApi.V1.Models.Shops
{
    public class Shop
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("sales_channel")]
        public string SalesChannel { get; set; }
    }
}
