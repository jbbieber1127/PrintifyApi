using Newtonsoft.Json;

namespace PrintifyApi.V1.Models.Shops.Orders.Create
{
    public interface IOrderCreationLineItem
    {

        [JsonProperty("blueprint_id")]
        public string BlueprintId { get; set; }

        [JsonProperty("print_details")]
        public PrintDetails PrintDetails { get; set; }
    }
}
