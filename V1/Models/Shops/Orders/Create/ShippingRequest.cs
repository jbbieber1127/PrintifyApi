using Newtonsoft.Json;

namespace PrintifyApi.V1.Models.Shops.Orders.Create
{
    public class ShippingRequest
    {
        [JsonProperty("line_items")]
        public List<IOrderCreationLineItem> LineItems { get; set; }

        [JsonProperty("address_to")]
        public AddressTo AddressTo { get; set; }
    }
}
