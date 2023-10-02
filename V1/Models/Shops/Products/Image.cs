using Newtonsoft.Json;

namespace PrintifyApi.V1.Models.Shops.Products
{
    public class Image
    {
        [JsonProperty("src")]
        public string Src { get; set; }

        [JsonProperty("scale")]
        public double Scale { get; set; }

        [JsonProperty("x")]
        public double X { get; set; }

        [JsonProperty("y")]
        public double Y { get; set; }

        [JsonProperty("angle")]
        public double Angle { get; set; }

    }

    
}
