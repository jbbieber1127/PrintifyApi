using Newtonsoft.Json;

namespace PrintifyApi.V1.Models.Shops.Products
{
    /// <summary>
    /// Placeholders represent a printable surface on a product. (Ex. for t-shirts there will be a placeholder for the front, back, left sleeve, right sleeve, etc.)
    /// </summary>
    public class Placeholder
    {
        [JsonProperty("position")]
        public string Position { get; set; }

        [JsonProperty("images")]
        public List<Design> Images { get; set; }
    }
}
